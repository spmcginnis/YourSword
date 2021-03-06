using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PopKuru.CharName;
using static PopKuru.CommandName;
using static PopKuru.Expression;

namespace PopKuru
{
    public class Line
    {
        public CharName Speaker {get; protected set;}
        public string StoryText {get; protected set;}
        public List<Command> Commands {get; protected set;}


        public Line(List<Command> commands = null, CharName speaker = none, string storyText = null)
        {
            BuildLine(commands, speaker, storyText);
        }

        public Line(Command commands, CharName speaker = none, string storyText = null)
        {
            List<Command> _commands = new List<Command>() {commands};
            BuildLine(_commands, speaker, storyText);
        }

        private void BuildLine(List<Command> commands = null, CharName speaker = none, string storyText = null)
        {
            if (commands == null)
            {
                commands = new List<Command>();
            }
            this.Speaker = speaker;
            this.StoryText = storyText;
            this.Commands = commands;
        }
    }
}
