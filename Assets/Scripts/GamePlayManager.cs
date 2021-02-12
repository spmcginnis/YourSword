using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class GamePlayManager : MonoBehaviour
    {
        ScreenPlay CurrentChapter;
        ScreenPlay NextChapter;
        List<ScreenPlay> NextChapterChoices;

        // Cashe the menu object
        GameObject[] Menus;
        const string menu = "Menu";

        void Awake()
        {
            Menus = GameObject.FindGameObjectsWithTag(menu);
        }

        void Start() // TEMP // TODO get the information from gamestate
        {
            CurrentChapter = new SampleScreenPlay();
            NextChapter = new GuildInterviewJin();
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

        // Show and hide menu
        public void ShowMenu(string name="test") // TODO string param currently not used
        {
            if ( Menus.Length==0 || Menus[0] == null ) { return; } // Will this be the case if it finds null?
            foreach (GameObject item in Menus)
            {
                item.GetComponent<Canvas>().sortingOrder = 1;
            }
        }
        public void HideMenu(string name="test")
        {
            if ( Menus.Length==0 || Menus[0] == null ) { return; }
            foreach (GameObject item in Menus)
            {
                item.GetComponent<Canvas>().sortingOrder = -1;
            }
        }
    }
}
