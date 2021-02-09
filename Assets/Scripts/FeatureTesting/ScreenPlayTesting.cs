using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace PopKuru
{
    public class ScreenPlayTesting : MonoBehaviour
    {
        private ScreenPlay CurrentChapter;
        private int Index; 

        TextMeshProUGUI SpeakerNameText;
        TextMeshProUGUI StoryText;

        void Awake()
        {
            SpeakerNameText = GameObject.Find("SpeakerNameText").GetComponent<TextMeshProUGUI>();
            StoryText = GameObject.Find("StoryText").GetComponent<TextMeshProUGUI>();
        }

        void Start()
        {
            CurrentChapter = new GuildInterviewJin();
        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (Index >= CurrentChapter.Text.Count) { Index = 0; }
                string speakerName = CurrentChapter.Text[Index].Speaker;
                string storyText = CurrentChapter.Text[Index].StoryText;
                string commandString = string.Join(" ", CurrentChapter.Text[Index].Commands.ToArray());
                
                print(
                    $"{speakerName}: {storyText} (With commands: {commandString})" // TEMP
                );

                SpeakerNameText.text = (speakerName != null)? speakerName : " ";
                StoryText.text = (storyText != null)? storyText : " ";

                Index++;

            }
        }
    }
}
