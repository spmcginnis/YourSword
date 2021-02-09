using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PopKuru
{
    public class SceneManager : MonoBehaviour
    {
        public Scene CurrentScene;
        //TODO Expose the necessary data from CurrentScene to Unity

        // Cashe the menu object
        GameObject[] Menus;
        const string menu = "Menu";

        // Cashe the ScreenPlay object
        ScreenPlay CurrentChapter;
        
        // Cashe the character objects for the scene.
        public List<Character> Characters {get; private set; }

        // Cashe the BackgroundImageLocations for the scene. //TODO Change to a list of location objects
        public Dictionary<string, string> BackgroundImages {get; private set; }

        void Awake()
        {
            Menus = GameObject.FindGameObjectsWithTag(menu);
            
            // Initialize the current chapter object.  Here?  or in Main?
            // TODO Get the chapter from game state
            CurrentChapter = new GuildInterviewJin();
            
            // Initialize the CurrentScene based on the gamestate 
            string GameStatePlaceholder = "StandardScene";
            
            switch (GameStatePlaceholder)
            {
                case "StandardScene":
                    CurrentScene = new StandardScene();
                    break;
                case "CutScene":
                    CurrentScene = new CutScene();
                    break;
                case "Intro":
                    CurrentScene = new CutScene(isIntro:true);
                    break;
                case "Ending":
                    CurrentScene = new CutScene(isEnding:true);
                    break;
                default:
                    Debug.Log("GameState switch-case: No match was detected; defaulted to Standard.");
                    CurrentScene = new StandardScene();
                    break;
            }
        }

        void Start()
        {
            LoadCharacters();
            LoadBackgrounds();

        }

        void Update()
        {
            if (CurrentScene == null) {return;}
            if (CurrentScene.IsDone) { LoadNext(CurrentScene.NextScene); }
        }


        // Transition to the next scene
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

        // Load character prefabs for the scene, off stage.
        void LoadCharacters()
        {
            if (CurrentChapter.CastOfCharacters.Count == 0) {return;} // Guard Clause

            Characters = new List<Character>();
            foreach (string name in CurrentChapter.CastOfCharacters)
            {
                Character toAdd = new Character(name);
                Characters.Add(toAdd);
            }
        }
        
        // TODO Load Character Prefabs offscreen
        void LoadCharacterPrefabs()
        {
            
        }

        // TODO Load Background Images as Location class objects rather than a dictionary of references
        void LoadBackgrounds()
        {
            if (CurrentChapter.BackgroundImagePaths.Count == 0) {return;} // Guard Clause
            BackgroundImages = CurrentChapter.BackgroundImagePaths;
        }

        // Call image transition from (where?)

        // Call music transition from (where?)
    }
}
