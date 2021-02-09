using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public abstract class ScreenPlay
    {
        public string Title {get; protected set;}

        // Full List of Names -> enum (?)
        protected const string margot = "Margot";
        protected const string jin = "Jin";

        // Full List of Commands -> enum (?) dictionary (?)
            // Expression and pose changes
        protected const string pleasant = "ChangeExpressionPleasant:";
        protected const string sarcastic = "ChangeExpressionSarcastic:";
        protected const string impassive = "ChangeExpressionImpassive:";
        protected const string grouchy = "ChangeExpressionFrown:";
        protected const string smug = "ChangeExpressionSmug:";
        protected const string startled = "ChangeExpressionStartled:";
        protected const string angry = "ChangeExpressionAngryBlush:";
        protected const string smirk = "ChangeExpressionSmirk:";
        protected const string blush = "ChangeExpressionBlush:";
        protected const string skeptical = "ChangeExpressionSkeptical:";
        protected const string disgusted = "ChangeExpressionDisgusted:";
            // Stage Directions
        protected const string enter = "Enter:";
        protected const string exit = "Exit:";
            // Dialogue Directions
        protected const string continued = "ContinuedText";
            // Scene Changes
        protected const string changeBackground = "ChangeBackground:"; // TODO add the background names to the available data.
        protected const string endChapter = "EndChapter";

        // ScreenPlay Fields and Properties
        public Dictionary<string, string> BackgroundImagePaths {get; protected set;} // TODO offload this to a location class
        public List<Line> Text {get; protected set;}
        public List<string> CastOfCharacters;

        public class Line
        {
            public string Speaker {get; protected set;}
            public string StoryText {get; protected set;}
            public List<string> Commands {get; protected set;}
            string LastSpeaker = "";

            public Line(    string speaker = "",
                            string storyText = "",
                            List<string> commands = null )
            {
                if (speaker == "")
                {
                    this.Speaker = this.LastSpeaker;
                }
                if (commands == null)
                {
                    commands = new List<string>();
                }
                this.Speaker = speaker;
                this.StoryText = storyText;
                this.Commands = commands;
                this.LastSpeaker = speaker;
            }
        }
    }
}

/* LINE TEMPLATE
{new Line(
    speaker:name,
    storyText: "",
    commands: new List<string>() {command, command}
)}
*/
