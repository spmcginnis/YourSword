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
               cassandra, lua, salvador, jin, margot, greylin, auden
            };

            // Expression list
            // starting, neutral
            // cheerful, annoyed, soft, sad, tearful, surprised, angry
            // blushing, superblushing, flirty, confused

            this.Text = new List<Line>()
            {
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeBackground, guildHall1),
                        new Command(enter, lua, right),
                        new Command(enter, cassandra, left),
                        new Command(enter, jin, center),
                        new Command(enter, salvador, left),
                        new Command(enter, margot, right),
                        new Command(enter, greylin, left),
                        new Command(enter, auden, right)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, starting),
                        new Command(changeExpression, lua, starting),
                        new Command(changeExpression, salvador, starting),
                        new Command(changeExpression, jin, starting),
                        new Command(changeExpression, margot, starting),
                        new Command(changeExpression, greylin, starting),
                        new Command(changeExpression, auden, starting)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, neutral),
                        new Command(changeExpression, lua, neutral),
                        new Command(changeExpression, salvador, neutral),
                        new Command(changeExpression, jin, neutral),
                        new Command(changeExpression, margot, neutral),
                        new Command(changeExpression, greylin, neutral),
                        new Command(changeExpression, auden, neutral)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, cheerful),
                        new Command(changeExpression, lua, cheerful),
                        new Command(changeExpression, salvador, cheerful),
                        new Command(changeExpression, jin, cheerful),
                        new Command(changeExpression, margot, cheerful),
                        new Command(changeExpression, greylin, cheerful),
                        new Command(changeExpression, auden, cheerful)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, annoyed),
                        new Command(changeExpression, lua, annoyed),
                        new Command(changeExpression, salvador, annoyed),
                        new Command(changeExpression, jin, annoyed),
                        new Command(changeExpression, margot, annoyed),
                        new Command(changeExpression, greylin, annoyed),
                        new Command(changeExpression, auden, annoyed)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, soft),
                        new Command(changeExpression, lua, soft),
                        new Command(changeExpression, salvador, soft),
                        new Command(changeExpression, jin, soft),
                        new Command(changeExpression, margot, soft),
                        new Command(changeExpression, greylin, soft),
                        new Command(changeExpression, auden, soft)                        
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, sad),
                        new Command(changeExpression, lua, sad),
                        new Command(changeExpression, salvador, sad),
                        new Command(changeExpression, jin, sad),
                        new Command(changeExpression, margot, sad),
                        new Command(changeExpression, greylin, sad),
                        new Command(changeExpression, auden, sad)
                    }
                )},
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, tearful),
                        new Command(changeExpression, lua, tearful),
                        new Command(changeExpression, salvador, tearful),
                        new Command(changeExpression, jin, tearful),
                        new Command(changeExpression, margot, tearful),
                        new Command(changeExpression, greylin, tearful),
                        new Command(changeExpression, auden, tearful)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, surprised),
                        new Command(changeExpression, lua, surprised),
                        new Command(changeExpression, salvador, surprised),
                        new Command(changeExpression, jin, surprised),
                        new Command(changeExpression, margot, surprised),
                        new Command(changeExpression, greylin, surprised),
                        new Command(changeExpression, auden, surprised)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, angry),
                        new Command(changeExpression, lua, angry),
                        new Command(changeExpression, salvador, angry),
                        new Command(changeExpression, jin, angry),
                        new Command(changeExpression, margot, angry),
                        new Command(changeExpression, greylin, angry),
                        new Command(changeExpression, auden, angry)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, blushing),
                        new Command(changeExpression, lua, blushing),
                        new Command(changeExpression, salvador, blushing),
                        new Command(changeExpression, jin, blushing),
                        new Command(changeExpression, margot, blushing),
                        new Command(changeExpression, greylin, blushing),
                        new Command(changeExpression, auden, blushing)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, superblushing),
                        new Command(changeExpression, lua, superblushing),
                        new Command(changeExpression, salvador, superblushing),
                        new Command(changeExpression, jin, superblushing),
                        new Command(changeExpression, margot, superblushing),
                        new Command(changeExpression, greylin, superblushing),
                        new Command(changeExpression, auden, superblushing)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, flirty),
                        new Command(changeExpression, lua, flirty),
                        new Command(changeExpression, salvador, flirty),
                        new Command(changeExpression, jin, flirty),
                        new Command(changeExpression, margot, flirty),
                        new Command(changeExpression, greylin, flirty),
                        new Command(changeExpression, auden, flirty)
                    }
                )},   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(changeExpression, cassandra, confused),
                        new Command(changeExpression, lua, confused),
                        new Command(changeExpression, salvador, confused),
                        new Command(changeExpression, jin, confused),
                        new Command(changeExpression, margot, confused),
                        new Command(changeExpression, greylin, confused),
                        new Command(changeExpression, auden, confused)
                    }
                )}
                ,   
                {new Line(
                    commands: new List<Command>()
                    {
                        new Command(exit, cassandra),
                        new Command(exit, lua),
                        new Command(exit, salvador),
                        new Command(exit, jin),
                        new Command(exit, margot),
                        new Command(exit, greylin),
                        new Command(exit, auden)
                    }
                )}

            };

        }

    }
}
