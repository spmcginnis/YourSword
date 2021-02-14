using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    // GameState abstract class
        // Inherited by SceneManager and GamePlayManager
        // Defines route paths
        // Conveys state of game data to its subclasses
        // A third subclass should handle save/load

    public class GameState : MonoBehaviour
    {
        // Chapter Navigation
            // Set by GamePlayManager
            // Read by SceneManager
        public ScreenPlay CurrentChapter {get; protected set;}
        protected List<ScreenPlay> NextChapterChoices;
        

        // TODO Route Paths Defined Here
        private class StateMap 
        {
            
            public StateMap()
            {

            }
        }
        /////////////////////////////////////////////////////
        public void SetCurrentChapter(ScreenPlay chapter)
        {
            CurrentChapter = chapter;
        }
        public ScreenPlay GetCurrentChapter()
        {
            return CurrentChapter;
        }

        protected void GoNextChapter(ScreenPlay choice = null)
        {   
            ScreenPlay cc = CurrentChapter;
            if (choice == null)
            {
                CurrentChapter = NextChapterChoices[0];
            }
            else
            {
                foreach (ScreenPlay chapter in NextChapterChoices)
                {
                    if (chapter.Title == choice.Title)
                    {
                        CurrentChapter = chapter;
                        break;
                    }
                }
            }
            if (CurrentChapter == cc)
            {
                Debug.LogWarning("No new chapter was selected. Reverted to current chapter.");
            }
            if (CurrentChapter == null)
            {
                CurrentChapter =  new GuildInterviewJin(); //TEMP replace with intro
                Debug.LogWarning("Current chapter null value. Reverted to default chapter.");

            }

        }
    }
}
