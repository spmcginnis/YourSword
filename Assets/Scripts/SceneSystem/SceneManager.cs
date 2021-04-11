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
        }

        public void SetUp(ScreenPlay currentChapter)
        {
            CharacterPanel = GameObject.Find("CharacterPanel").GetComponent<RectTransform>();
            CurrentChapter = currentChapter;
            Mover = new Mover((float) Screen.width);
            Characters = new List<Character>();
            LoadCharacters();
            // LoadCutScenes(); // If cutscenes are part of standardscene // cutscene and special cutscene? cutscene and cinematic?
            // TODO Destroy Mover when setup is complete.
        }

        void LoadCharacters()
        {
            if (CurrentChapter.CastOfCharacters.Count == 0) {return;} // Guard Clause

            foreach (CharName charName in CurrentChapter.CastOfCharacters)
            {
                // Identify and load prefab, RectTransform // I think I have to use prefabs for the positioning.
                GameObject prefab = Instantiate(Resources.Load($"Prefabs/CharacterPrefabs/Character[{charName}]") as GameObject); // Load the prefab as GO and instantiate it
                prefab.transform.SetParent(CharacterPanel); // Set the parent property to be the character panel

                Sprite thumbnail = Resources.Load<Sprite>($"Images/Thumbnails/{charName}Thumbnail");
                Character character = new Character(charName, prefab, thumbnail);
                
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
