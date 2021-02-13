using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    //uses the info from gamestate to control the flow of a scene:
        // user input
        // character movement
        // image transitions
        // background changes
        // text display
        // menu interactions
    
    // Should these inherit from gamestate???

    public class GamePlayManager : MonoBehaviour
    {
        // Cashe the menu object
        GameObject[] Menus;
        const string menu = "Menu"; // TODO refactor menus to use prefab system like characters

        // // Unity Game Objects
        RectTransform CharacterPanel;

        // Mover
        Mover Mover;

        ScreenPlay CurrentChapter;
        List<ScreenPlay> NextChapterChoices;

        SceneManager SceneManager;

        void Awake()
        {
            CharacterPanel = GameObject.Find("CharacterPanel").GetComponent<RectTransform>();
            Menus = GameObject.FindGameObjectsWithTag(menu);

            // TODO implement GoNextChapter();
            CurrentChapter = new SampleScreenPlay(); // TEMP // TODO get the information from gamestate
            NextChapterChoices = new List<ScreenPlay>()
            {
              {new GuildInterviewJin()}  
            };

        }

        void Start() 
        {
            SceneManager = GameObject.Find("Managers").GetComponent<SceneManager>();
            SceneManager.SetUp(CurrentChapter);
        }

        void Update()
        {
            // User input

            // Check for changes to the game state

            // Behavior for moving to the next chapter
        }

        // Transition to the next scene // Changes scene type
        public IEnumerator LoadNext(Scene nextScene){
            SaveGame();
            yield break;
        }

        //TODO put this in SaveLoadManager or GameState (?)
        public IEnumerator SaveGame(){
            yield break;
        }

        public void ShowMenu() // Change to load the root menu.
        {
            if ( Menus.Length==0 || Menus[0] == null ) { return; } // Will this be the case if it finds null?
            foreach (GameObject item in Menus)
            {
                item.GetComponent<Canvas>().sortingOrder = 1;
            }

            //TODO Override user input
        }

        public void HideMenu()
        {
            if ( Menus.Length==0 || Menus[0] == null ) { return; }
            foreach (GameObject item in Menus)
            {
                item.GetComponent<Canvas>().sortingOrder = -1;
            }
        }

        public void ShowSubMenu(string menuName) // overload for switching between menus
        {

        }

        public void HideSubMenu(string menuName)
        {

        }
    }
}
