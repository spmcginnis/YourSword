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

        void Start()
        {
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

            // Testing to initialize a character

            Character TestName = new Character("Margot");

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

        public IEnumerator SaveGame(){
            yield break;
        }

        // Call image transition from (where?)

        // Call music transition from (where?)
    }
}
