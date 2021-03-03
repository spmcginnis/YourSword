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
            Characters = new List<Character>(); // Is this necessary?
            CurrentChapter = null;
            CharacterPanel = GameObject.Find("CharacterPanel").GetComponent<RectTransform>();
        }

        public void SetUp(ScreenPlay currentChapter)
        {
            CurrentChapter = currentChapter;
            Mover = new Mover((float) Screen.width);
            LoadCharacters();
            LoadCharacterPrefabs();
            // LoadCutScenes(); // If cutscenes are part of standardscene // cutscene and special cutscene? cutscene and cinematic?
            // Destroy Mover when setup is complete.
        }

        void LoadCharacters()
        {
            if (CurrentChapter.CastOfCharacters.Count == 0) {return;} // Guard Clause
            Characters = new List<Character>();
            // TODO change the input type from generic string to controlled vocabulary
            foreach (CharName name in CurrentChapter.CastOfCharacters)
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
                Mover.MoveTo(character.RT, StagePosition.offStage); // move offstage to start
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
