using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PopKuru.CharName;
using static PopKuru.CommandName;
using static PopKuru.Expression;
using static PopKuru.StagePosition;

namespace PopKuru
{
    public class SampleScreenPlay : ScreenPlay
    {
        public SampleScreenPlay()
        {
            this.Title = "Sample ScreenPlay for Testing";
            this.CastOfCharacters = new List<CharName>()
            {
                margot
            };

            this.Text = new List<Line>()
            {
                new Line
                (
                    new Command(enter, margot, center),
                    speaker: margot,
                    "Oh, it appears I'm all by my lonesome..."
                )
                
            };
        }
    }
}
