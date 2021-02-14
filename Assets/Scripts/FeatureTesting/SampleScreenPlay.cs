using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PopKuru.CharName;
using static PopKuru.CommandName;
using static PopKuru.Expression;

namespace PopKuru
{
    public class SampleScreenPlay : ScreenPlay
    {
        public SampleScreenPlay()
        {
            this.Title = "Sample ScreenPlay for Testing";
            this.CastOfCharacters = new List<CharName>()
            {
                margot, jin
            };

            this.Text = new List<Line>()
            {
                new Line
                (
                    new Command(changeExpression, margot, pleasant),
                    speaker: margot,
                    "Oh, sorry...you’re the one who wanted to apply for guild membership today, aren’t you? I wasn’t expecting you for a while."
                )
                
            };
        }
    }
}
