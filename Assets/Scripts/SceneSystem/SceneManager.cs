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
            // Initialize the CurrentScene
        }

        void Update()
        {
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
