using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace PopKuru
{
    public class ScreenPlayTesting : MonoBehaviour
    {
        ScreenPlay CurrentChapter;
        int Index; 

        // GUI Elements
        TextMeshProUGUI SpeakerNameTextBox;
        TextMeshProUGUI StoryTextBox;
        List<BackgroundImage> Backgrounds;
        GameObject BackgroundPanel;
        Image BPImageHook;
        List<Character> Characters;

        // Dialogue and Command Handling
        string SpeakerName;
        string StoryText;
        List<Command> Commands;
        CharName CurrentSpeaker;
        CharName LastSpeaker;
        string CommandString;

        // Character Moving
        Mover Mover;


        void Awake()
        {
            SpeakerNameTextBox = GameObject.Find("SpeakerNameText").GetComponent<TextMeshProUGUI>();
            StoryTextBox = GameObject.Find("StoryText").GetComponent<TextMeshProUGUI>();

            Backgrounds = new List<BackgroundImage>();

            BackgroundPanel = GameObject.Find("BackgroundPanel").transform.Find("Image").gameObject;
            BPImageHook = BackgroundPanel.GetComponent<Image>();
            
            LastSpeaker = CharName.none;
            CommandString = "";
            Mover = new Mover((float) Screen.width);
            Debug.Log("screen width: " + Screen.width);
        }

        void Start()
        {
            CurrentChapter = new GuildInterviewJin();
            Backgrounds.Add(new BackgroundImage(BackgroundImage.ImageNameEnum.GuildHall1));
            
            BPImageHook.color = new Color (1f, 1f, 1f, a:0.5f);
            BPImageHook.sprite = Resources.Load<Sprite>(Backgrounds[0].File);
            // TODO factor out into separate method that sets the image and the color(alpha) in one call.
            // The call to set an image should happen in GameManager (Main), not SceneManager.  The functionality should be defined in backgroundimage.
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (Index >= CurrentChapter.Text.Count) { Index = 0; } // TEMP // Resets the index at the end for testing purposes.
                
                // Text Handling
                CurrentSpeaker = CurrentChapter.Text[Index].Speaker;

                if (CurrentSpeaker == null || CurrentSpeaker == CharName.none)
                {
                    SpeakerName = LastSpeaker.ToString("g");
                }
                else
                {
                    LastSpeaker = CurrentSpeaker;
                    SpeakerName = CurrentSpeaker.ToString("g");
                }

                StoryText = CurrentChapter.Text[Index].StoryText;

                SpeakerNameTextBox.text = (StoryText != null) ? SpeakerName : " ";
                StoryTextBox.text = (StoryText != null) ? StoryText : " ";

                // Command Handling
                Commands = CurrentChapter.Text[Index].Commands;

                if (Commands != null)
                {
                    CommandString = "";
                    foreach (Command command in Commands)
                    {
                        CommandString += command.ToString();

                        if (command.CommandName == CommandName.enter)
                        {

                        }

                    }
                }
                
                print(
                    $"Index:{Index} {SpeakerName}: {StoryText} {(CommandString!=""?"("+CommandString+")":"")}" // TEMP
                );

                Index++;
            }

            if (Input.GetKeyDown(KeyCode.I))
            {             
                print(Backgrounds[0].File);
            }
        }
    }
}
