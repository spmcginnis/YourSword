using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PopKuru
{     
    public class SceneManager : MonoBehaviour
    {
        Scene CurrentScene; // NOT USED RIGHT NOW // TODO use scene type to determine menus and gui elements
        
        // Cashe the character objects for the scene.  The Character object has a rect transform property.
        public List<Character> Characters {get; private set; }

        // // Unity Game Objects
        RectTransform CharacterPanel;

        // Mover
        Mover Mover;

        ScreenPlay CurrentChapter;

        void Awake()
        {
            CurrentChapter = null;
            CharacterPanel = GameObject.Find("CharacterPanel").GetComponent<RectTransform>();
        }

        public void SetUp(ScreenPlay currentChapter)
        {
            CurrentChapter = currentChapter;
            Mover = new Mover((float) Screen.width);
            Characters = new List<Character>();
            LoadCharacters();
            // LoadCutScenes(); // If cutscenes are part of standardscene // cutscene and special cutscene? cutscene and cinematic?
            // Destroy Mover when setup is complete.
        }

        void LoadCharacters() // TODO Merge LoadCharacters and LoadCharacterPrefabs.  Pass Character a RT at initialization
        {
            if (CurrentChapter.CastOfCharacters.Count == 0) {return;} // Guard Clause

            foreach (CharName charName in CurrentChapter.CastOfCharacters)
            {
                // Identify and load prefab, RectTransform
                Object prefab = Resources.Load($"Prefabs/CharacterPrefabs/Character[{charName}]"); // 1. load the prefab
                GameObject prefabGameObj = Instantiate(prefab) as GameObject; // 2. Instantiate the prefab as a GameObject
                prefabGameObj.transform.SetParent(CharacterPanel); // 3. Set the parent property to be the character panel
                RectTransform RT = prefabGameObj.GetComponent<RectTransform>();

                Character character = new Character(charName, RT);
                
                // Add it to the list
                Characters.Add(character); 
                
                // move offstage to start
                Mover.MoveTo(character.RT, StagePosition.offStage);
            }
        }

        void SetSceneType()
        {
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
    }
}
