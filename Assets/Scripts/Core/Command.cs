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
        public Expression Expression {get; private set;}
        public StagePosition Position {get; private set;}
        public List<string> Args {get; private set;}

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
        // Constructor for stage directions
        public Command (CommandName name, CharName character, StagePosition position)
        {
            Name = name;
            Character = character;
            Position = position;
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

        public override string ToString()
        {
            return $"CommandName: {(Name!=null? Name.ToString(): "")}, CharName {(Character!=null? Character.ToString(): "") }, ImageName: {(ImageName!=null? ImageName : "")}, Expression: {(Expression!=null? Expression.ToString(): "")}, StagePosition: {(Position!=null? Position.ToString():"")}, Args: {(Args!=null? Args.ToString():"")}" ;
        }
    }
}
