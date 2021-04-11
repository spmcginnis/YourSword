using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static PopKuru.CharName;

namespace PopKuru
{
    public class TextManager
    {   
        // GUI Elements
        TextMeshProUGUI SpeakerNameTextBox;
        TextMeshProUGUI StoryTextBox;

        // Tracking the Speaker
        public CharName CurrentSpeaker {get; private set;}
        CharName LastSpeaker;
        string SpeakerName;

        public TextManager(TextMeshProUGUI speakerNameTextBox, TextMeshProUGUI storyTextBox)
        {
            SpeakerNameTextBox = speakerNameTextBox;
            StoryTextBox = storyTextBox;
            LastSpeaker = none; // TODO is this necessary?
        }
        
        // Process Text and Text related commands
        public void ReadLine(Line line)
        {
            Debug.Log("Storytext is " + line.StoryText);
            
            if (line.StoryText == null)
            {
                SpeakerNameTextBox.text = " ";
                StoryTextBox.text = " ";
                return;
            }
            
            CurrentSpeaker = line.Speaker;

            if (CurrentSpeaker == null || CurrentSpeaker == none)
            {
                CurrentSpeaker = LastSpeaker; 
                SpeakerName = CurrentSpeaker.ToString("g");
            }
            else
            {
                LastSpeaker = CurrentSpeaker;
                SpeakerName = CurrentSpeaker.ToString("g");
            }

            SpeakerNameTextBox.text = SpeakerName;
            StoryTextBox.text = line.StoryText;
        }

        // TODO Find last speaker
        // TODO Process text and speaker
    }
}
