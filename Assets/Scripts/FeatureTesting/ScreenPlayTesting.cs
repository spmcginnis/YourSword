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
                string commandString = string.Join(" ", CurrentChapter.Text[Index].Commands.ToArray());
                print(
                    $"{CurrentChapter.Text[Index].Speaker}: {CurrentChapter.Text[Index].StoryText} (With commands: {commandString})"
                );
                Index++;

            }
        }
    }
}
