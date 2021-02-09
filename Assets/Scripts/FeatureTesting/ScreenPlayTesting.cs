using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class ScreenPlayTesting : MonoBehaviour
    {
        private ScreenPlay ChapterTest;
        private int Index; 

        void Start()
        {
            ChapterTest = new GuildInterviewJin();
        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (Index >= ChapterTest.Text.Count) { Index = 0; }
                print(ChapterTest.Text[Index].StoryText);
                Index++;

            }
        }
    }
}
