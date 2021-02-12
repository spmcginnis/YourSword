using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class SampleScreenPlay : ScreenPlay
    {
        public SampleScreenPlay()
        {
            this.Title = "Sample ScreenPlay for Testing";
            this.CastOfCharacters = new List<string>()
            {
                margot, jin
            };

            this.Text = new List<Line>()
            {
                {new Line(
                    speaker: margot,
                    "Oh, sorry...you’re the one who wanted to apply for guild membership today, aren’t you? I wasn’t expecting you for a while.",
                    new List<string>() {pleasant+margot}
                )}
            };
        }
    }
}
