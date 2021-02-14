using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PopKuru.CharName;
using static PopKuru.CommandName;
using static PopKuru.Expression;

namespace PopKuru
{
    public abstract class ScreenPlay
    {
        public string Title {get; protected set;}

        // ScreenPlay Fields and Properties
        public Dictionary<string, string> BackgroundImagePaths {get; protected set;} // TODO offload this to a location class
        public List<Line> Text {get; protected set;}
        public List<CharName> CastOfCharacters;

        public class Line
        {
            public CharName Speaker {get; protected set;}
            public string StoryText {get; protected set;}
            public List<Command> Commands {get; protected set;}

            public Line(    List<Command> commands = null,
                            CharName speaker = none,
                            string storyText = ""   )
            {
                if (commands == null)
                {
                    commands = new List<Command>();
                }
                this.Speaker = speaker;
                this.StoryText = storyText;
                this.Commands = commands;
            }

            public Line(    Command commands,
                            CharName speaker = none,
                            string storyText = ""   )
            {
                List<Command> _commands = new List<Command>() {commands};
                new Line(_commands, speaker, storyText);
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
