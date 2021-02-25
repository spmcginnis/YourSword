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
        CharName CurrentSpeaker;
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
            CurrentSpeaker = line.Speaker;

            if (CurrentSpeaker == null || CurrentSpeaker == none)
            {
                SpeakerName = LastSpeaker.ToString("g");
            }
            else
            {
                LastSpeaker = CurrentSpeaker;
                SpeakerName = CurrentSpeaker.ToString("g");
            }

            SpeakerNameTextBox.text = (line.StoryText != null) ? SpeakerName : " ";
            StoryTextBox.text = (line.StoryText != null) ? line.StoryText : " ";
        }

        // TODO Find last speaker
        // TODO Process text and speaker
    }
}
