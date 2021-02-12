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

        // Cashe the ScreenPlay object
        ScreenPlay CurrentChapter;
        
        // Cashe the character objects for the scene.
        public List<Character> Characters {get; private set; }

        // Cashe the BackgroundImageLocations for the scene. //TODO Change to a list of location objects
        public Dictionary<string, string> BackgroundImages {get; private set; }

        // Unity Game Objects
        public RectTransform CharacterPanel {get; private set;}

        // Mover // TODO put mover on game controller (?)
        private Mover Mover;

        void Awake()
        {

            CharacterPanel = GameObject.Find("CharacterPanel").GetComponent<RectTransform>();
            
            // TODO Change to get the chapter from game state
            CurrentChapter = new SampleScreenPlay(); // TEMP
            
            // Initialize the CurrentScene based on the gamestate
            // This will determine what components are loaded into the hierarchy
            // Also has ramifications for menu options 
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
            Mover = new Mover((float) CharacterPanel.rect.width);
            // LoadBackgrounds(); // Don't show them yet.  Show/hide should be handled by GamePlayManager.
            LoadCharacters();
            LoadCharacterPrefabs();
            // LoadCutScenes(); // If cutscenes are part of standardscene // cutscene and special cutscene? cutscene and cinematic?
        }

        void Update()
        {

        }



        void LoadCharacters()
        {
            if (CurrentChapter.CastOfCharacters.Count == 0) {return;} // Guard Clause
            Characters = new List<Character>();
            // TODO change the input type from generic string to controlled vocabulary
            foreach (string name in CurrentChapter.CastOfCharacters)
            {
                Character toAdd = new Character(name);
                Characters.Add(toAdd);
            }
        }
    
        void LoadCharacterPrefabs() // attach the prefab to the character panel
        {
            foreach (Character character in Characters)
            {
                Object prefab = Resources.Load($"Prefabs/CharacterPrefabs/Character[{character.Name}]"); // 1. load the prefab
                GameObject prefabGameObj = Instantiate(prefab) as GameObject; // 2. Instantiate the prefab as a GameObject
                prefabGameObj.transform.SetParent(CharacterPanel); // 3. Set the parent property to be the character panel
                character.RT = prefabGameObj.GetComponent<RectTransform>();
                Mover.MoveTo(character.RT, StagePosition.center); // move offstage to start
            }
        }

        // TODO Load Background Images as Location class objects rather than a dictionary of references
        void LoadBackgrounds()
        {
            if (CurrentChapter.BackgroundImagePaths == null) {return;}
            if (CurrentChapter.BackgroundImagePaths.Count == 0) {return;} // Guard Clause
            BackgroundImages = CurrentChapter.BackgroundImagePaths;
        }

        // Call image transition from (where?) // Call music transition from (where?) // No.  Transitions will be called by the game manager.
        
    }
}
