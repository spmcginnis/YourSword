using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace PopKuru
{
    public class TextManager
    {   
        // GUI Elements
        TextMeshProUGUI SpeakerNameTextBox;
        TextMeshProUGUI StoryTextBox;

        public TextManager(TextMeshProUGUI speakerNameTextBox, TextMeshProUGUI storyTextBox)
        {
            SpeakerNameTextBox = speakerNameTextBox;
            StoryTextBox = storyTextBox;
        }
        
        // Process Text and Text related commands
        public void ReadLine(Line line)
        {
            Debug.LogWarning("Text Manager not implemented.");
        }

        // TODO Find last speaker
        // TODO Process text and speaker
    }
}
