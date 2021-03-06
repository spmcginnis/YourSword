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
        TextManager TextManager;

        // Cashe the menu object
        GameObject[] Menus;
        const string menu = "Menu"; // TODO refactor menus to use prefab system like characters

        // Text Boxes
        TextMeshProUGUI SpeakerNameTextBox;
        TextMeshProUGUI StoryTextBox;

        // Thumbnail Hook
        Image ThumbHook;

        // Characters
        List<Character> Characters;

        // Mover
        Mover Mover;
        int ScreenWidth;

        // Background Images
        BackgroundManager BackgroundManager;
        GameObject BackgroundPanel;

        // TEMP
        List<ScreenPlay> NextChapterChoices; // TODO offload to gamestate
        
        // ScreenPlay
        ScreenPlay CurrentChapter;
        Line CurrentLine;
        int LineNumber;
        
        // Command Handling
        List<Command> Commands;
        string CommandString;

        void Awake()
        {
            // TODO Menus
            Menus = GameObject.FindGameObjectsWithTag(menu);

            // Instantiate the Scene Manager
            SceneManager = GameObject.Find("Managers").GetComponent<SceneManager>();
            
            // TEMP // TODO get the information from gamestate 
            CurrentChapter = new CharacterTesting();
            // CurrentChapter = new GuildInterviewJin();
                // The awake call will happen on game start, right? so this should call the loading and title scenes (?)
            
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

            // Instantiate Background Manager
            BackgroundPanel = GameObject.Find("BackgroundPanel");
            BackgroundManager = new BackgroundManager(BackgroundPanel);

            // Cashe the ThumbHook
            ThumbHook = GameObject.Find("SpeakerFace").GetComponent<Image>();
        }

        void Start() 
        {
            
        }

        void Update()
        {
            // TODO Implement auto forwarding when there is a command with no associated text.  There could be a wait time depending on the command.  For example, a background change with a transition might have a delay before forwarding, while a character entrance or exit might not need one, or it might need a shorter one.
            if (LineNumber >= CurrentChapter.Text.Count)
            {
                CurrentChapter = new GuildInterviewJin();
                LineNumber = 0;
                Debug.LogWarning("Chapter restarted. Advancing to the next chapter not yet implemented.", this);
                //TODO signal the end of the chapter and call GoNextChapter();
            }
            
            // Check for changes to the window
            if (Screen.width !=  ScreenWidth)
            {
                ScreenWidth = Screen.width;
                Mover.ReSize((float) ScreenWidth);
                // TODO reposition characters based on the changed screen width
            }

            if (LineNumber == 0)
            {
                Debug.Log("Press spacebar to begin.");
            }

            // User input
            if (Input.GetKeyDown(KeyCode.Space))
            {      
                ProcessLine();              
            }
            
            // TODO Check for changes to the game state... such as ?
        }

        int CountCharactersOnSide(StagePosition position)
        {   
            Debug.Log($"CountCOS fired. StagePosition is {position}");
            int count = 0;
            int side = 0;

            if (position == StagePosition.left)
            {
                side = -1;
            } 
            else if (position == StagePosition.right)
            {
                side = 1;
            }
            else
            {
                Debug.Log($"CountCOS returned without counting");
                return 0;
            }
            
            RectTransform characterPanel = (RectTransform) GameObject.Find("CharacterPanel").transform;
            
            foreach (RectTransform child in characterPanel)
            {
                if (child.anchoredPosition.x * side > 0)
                {
                    count += 1;
                    Debug.Log($"Child.anchoredPosition.x is {child.anchoredPosition.x} side modifier is {side} and side/position is {position}");
                }
            }

            return count;
        }

        void ProcessLine()
        {
            CurrentLine = CurrentChapter.Text[LineNumber];
            // TODO Implement an image manager 
            // ImageManager.ProcessCommand(Command command)

            // TODO Handle commands // TODO implement a command manager (?)
            foreach (Command command in CurrentLine.Commands)
            {
                Debug.Log(command.ToString());
                if (command.CommandName == CommandName.enter || command.CommandName == CommandName.move)
                {
                    foreach (Character character in Characters)
                    {
                        if (command.Character == character.Name)
                        {
                            // check for characters at the position
                            int count = CountCharactersOnSide(command.Position);
                            Debug.Log($"Count on {command.Position} is {count}");

                            Mover.MoveTo(character.RT, command.Position, count);
                        }
                        
                    }
                }

                if (command.CommandName == CommandName.exit) 
                {
                    foreach (Character character in Characters)
                    {
                        if (command.Character == character.Name)
                        {
                            Mover.MoveTo(character.RT, StagePosition.offStage);
                        }
                        
                    } 
                }

                // TODO // Simple move command that is not enter exit

                if (command.CommandName == CommandName.changeBackground)
                {
                    BackgroundManager.LoadBackground(command.ImageName);
                    Debug.Log("LoadBackground called");
                }

                if (command.CommandName == CommandName.changeExpression)
                {
                    foreach (Character character in Characters)
                    {
                        if (command.Character == character.Name)
                        {
                            character.ChangeExpression(command.Expression);
                        }
                    }
                }
            }

            // Call text manager on the current line
            TextManager.ReadLine(CurrentLine);
            if (CurrentLine.StoryText != null)
            {
                // Speaker name from text manager
                // Thumbnail from scene manager
                foreach (Character character in Characters)
                {
                    if (character.Name == TextManager.CurrentSpeaker)
                    {
                        setThumb(character);
                    }
                }
                Debug.Log("Current speaker is " + TextManager.CurrentSpeaker);
            }
            
            LineNumber++;
        }

        void setThumb(Character character)
        {
            // Ref the game object.
            ThumbHook.sprite = character.Thumbnail;
        }

        // TODO Transition to the next scene // Changes scene type
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
