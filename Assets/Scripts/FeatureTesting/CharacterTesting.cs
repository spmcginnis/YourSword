using System.Collections;
using System.Collections.Generic;
using static PopKuru.CharName;
using static PopKuru.CommandName;
using static PopKuru.Expression;
using static PopKuru.StagePosition;
using static PopKuru.BackgroundName;

namespace PopKuru
{
    public class CharacterTesting : ScreenPlay
    {
        public CharacterTesting()
        {
            this.Title = "Character Testing";
            this.Backgrounds = new List<BackgroundName>()
            {
                guildHall1
            };
            this.CastOfCharacters = new List<CharName>()
            {
               cassandra, lua, salvador
            };

            this.Text = new List<Line>()
            {
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeBackground, guildHall1),
                        new Command(enter, cassandra, right),
                        new Command(enter, lua, right),
                        new Command(enter, salvador, right)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, neutral),
                        new Command(changeExpression, lua, neutral),
                        new Command(changeExpression, salvador, neutral)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, cheerful),
                        new Command(changeExpression, lua, cheerful),
                        new Command(changeExpression, salvador, cheerful)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, annoyed),
                        new Command(changeExpression, lua, annoyed),
                        new Command(changeExpression, salvador, annoyed)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, soft),
                        new Command(changeExpression, lua, soft),
                        new Command(changeExpression, salvador, soft)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, sad),
                        new Command(changeExpression, lua, sad),
                        new Command(changeExpression, salvador, sad)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, tearful),
                        new Command(changeExpression, lua, tearful),
                        new Command(changeExpression, salvador, tearful)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, surprised),
                        new Command(changeExpression, lua, surprised),
                        new Command(changeExpression, salvador, surprised)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, angry),
                        new Command(changeExpression, lua, angry),
                        new Command(changeExpression, salvador, angry)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, blushing),
                        new Command(changeExpression, lua, blushing),
                        new Command(changeExpression, salvador, blushing)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, superblushing),
                        new Command(changeExpression, lua, superblushing),
                        new Command(changeExpression, salvador, superblushing)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, flirty),
                        new Command(changeExpression, lua, flirty),
                        new Command(changeExpression, salvador, flirty)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, confused),
                        new Command(changeExpression, lua, confused),
                        new Command(changeExpression, salvador, confused)
                    }
                )}
                ,   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(exit, cassandra),
                        new Command(exit, lua),
                        new Command(exit, salvador)
                    }
                )}

            };

        }

    }
}
