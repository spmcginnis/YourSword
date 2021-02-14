using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PopKuru.CharName;
using static PopKuru.CommandName;
using static PopKuru.Expression;

namespace PopKuru
{
    public class Command
    {
        public CommandName Name {get; private set;}
        public CharName Character {get; private set;}
        public string ImageName {get; private set;} // TEMP // TODO background image classes
        public List<string> Args {get; private set;}
        public Expression Expression;
        // Constructor for characters
        public Command (CommandName name, CharName character, List<string> args = null)
        {
            Name = name;
            Character = character;
            Args = args;
        }
        
        // Constructor for expression changes, end chapter etc.
        public Command (CommandName name, CharName character, Expression expression)
        {
            Name = name;
            Character = character;
            Expression = expression;
        }


        // Constructor for images
        public Command (CommandName name, string imageName, List<string> args = null)
        {
            Name = name;
            ImageName = imageName;
            Args = args;
        }

        // Constructor for scene changes e.g. small cutscene, end chapter etc.
        public Command (CommandName name, List<string> args = null)
        {
            Name = name;
            Args = args;
        }
    }
}
