using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace PopKuru
{
    public class GamePlayManager : MonoBehaviour
    {
        // Managers
        SceneManager SceneManager;
        TextManager TextManager; // Not yet implemented

        // Cashe the menu object
        GameObject[] Menus;
        const string menu = "Menu"; // TODO refactor menus to use prefab system like characters

        // Text Boxes
        TextMeshProUGUI SpeakerNameTextBox;
        TextMeshProUGUI StoryTextBox;

        // Characters
        List<Character> Characters;

        // Mover
        Mover Mover;

        // TEMP
        List<ScreenPlay> NextChapterChoices; // TODO offload to gamestate
        
        // ScreenPlay
        ScreenPlay CurrentChapter;
        Line CurrentLine;
        int LineNumber;
        
        // Dialogue and Command Handling
        string SpeakerName;
        string StoryText;
        List<Command> Commands;
        CharName CurrentSpeaker;
        CharName LastSpeaker;
        string CommandString;

        int ScreenWidth;

        void Awake()
        {
            // TODO Menus
            Menus = GameObject.FindGameObjectsWithTag(menu);

            // Instantiate the Scene Manager
            SceneManager = GameObject.Find("Managers").GetComponent<SceneManager>();
            CurrentChapter = new GuildInterviewJin(); // TEMP // TODO get the information from gamestate
            NextChapterChoices = new List<ScreenPlay>() // TEMP // TODO get the information from gamestate
            {
              {new GuildInterviewJin()}  
            };
            SceneManager.SetUp(CurrentChapter);
            Characters = SceneManager.Characters;

            // Instantiate the Mover
            ScreenWidth = Screen.width;
            Mover = new Mover((float) ScreenWidth);

            // Instantiate Text Manager
            SpeakerNameTextBox = GameObject.Find("SpeakerNameText").GetComponent<TextMeshProUGUI>();
            StoryTextBox = GameObject.Find("StoryText").GetComponent<TextMeshProUGUI>();
            TextManager = new TextManager(SpeakerNameTextBox, StoryTextBox);
        }

        void Start() 
        {
            
        }

        void Update()
        {
            if (LineNumber >= CurrentChapter.Text.Count)
            {
                return;
                //TODO signal the end of the chapter and call GoNextChapter();
            }
            
            // Check for changes to the window
            if (Screen.width !=  ScreenWidth)
            {
                ScreenWidth = Screen.width;
                Mover.ReSize((float) ScreenWidth);
                Debug.Log("ScreenWidth recalibrated to " + ScreenWidth);
                // TODO reposition characters based on the changed screen width
            }

            // Check for changes to the game state

            // User input
            if (Input.GetKeyDown(KeyCode.Space))
            {
                CurrentLine = CurrentChapter.Text[LineNumber];
                
                // Call text manager on the current line
                TextManager.ReadLine(CurrentLine);

                // TODO Implement an image manager 
                // ImageManager.ProcessCommand(Command command)

                // TODO Handle commands // TODO implement a command manager (?)
                foreach (Command command in CurrentLine.Commands)
                {
                    Debug.Log(command.ToString());
                    if (command.CommandName == CommandName.enter || command.CommandName == CommandName.exit)
                    {
                        print("Command " + command.CommandName);

                        foreach (Character character in Characters)
                        {
                            if (command.Character == character.Name)
                            {
                                Mover.MoveTo(character.RT, command.Position);
                            }
                            
                        }
                    }
                }

                

                // Advance the line number
                LineNumber++;
            }
        }

        // Transition to the next scene // Changes scene type
        public IEnumerator LoadNext(Scene nextScene){
            SaveGame();
            yield break;
        }

        //TODO put this in SaveLoadManager or GameState (?)
        public IEnumerator SaveGame(){
            yield break;
        }

        public void ShowMenu() // Change to load the root menu.
        {
            if ( Menus.Length==0 || Menus[0] == null ) { return; } // Will this be the case if it finds null?
            foreach (GameObject item in Menus)
            {
                item.GetComponent<Canvas>().sortingOrder = 1;
            }

            //TODO Override user input
        }

        public void HideMenu()
        {
            if ( Menus.Length==0 || Menus[0] == null ) { return; }
            foreach (GameObject item in Menus)
            {
                item.GetComponent<Canvas>().sortingOrder = -1;
            }
        }

        public void ShowSubMenu(string menuName) // overload for switching between menus
        {

        }

        public void HideSubMenu(string menuName)
        {

        }
    }
}
