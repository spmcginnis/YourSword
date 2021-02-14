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

        TextMeshProUGUI SpeakerNameText;
        TextMeshProUGUI StoryText;
        List<BackgroundImage> Backgrounds;

        GameObject BackgroundPanel;
        Image BPImageHook;

        void Awake()
        {
            SpeakerNameText = GameObject.Find("SpeakerNameText").GetComponent<TextMeshProUGUI>();
            StoryText = GameObject.Find("StoryText").GetComponent<TextMeshProUGUI>();

            Backgrounds = new List<BackgroundImage>();

            BackgroundPanel = GameObject.Find("BackgroundPanel").transform.Find("Image").gameObject;
            BPImageHook = BackgroundPanel.GetComponent<Image>();
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
                if (Index >= CurrentChapter.Text.Count) { Index = 0; }
                string speakerName = CurrentChapter.Text[Index].Speaker.ToString("g");
                string storyText = CurrentChapter.Text[Index].StoryText;
                string commandString = "Command parsing not implemented."; // TEMP
                
                print(
                    $"{speakerName}: {storyText} ({commandString})" // TEMP
                );

                SpeakerNameText.text = (speakerName != null)? speakerName : " ";
                StoryText.text = (storyText != null)? storyText : " ";

                Index++;

            }

            if (Input.GetKeyDown(KeyCode.I))
            {

                
                print(Backgrounds[0].File);
            }
        }
    }
}
