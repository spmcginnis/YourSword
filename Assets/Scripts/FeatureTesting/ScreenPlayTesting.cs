using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class ScreenPlayTesting : MonoBehaviour
    {
        private ScreenPlay CurrentChapter;
        private int Index; 

        void Start()
        {
            CurrentChapter = new GuildInterviewJin();
        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (Index >= CurrentChapter.Text.Count) { Index = 0; }
                print(CurrentChapter.Text[Index].StoryText);
                Index++;

            }
        }
    }
}
