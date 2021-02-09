using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class GuildInterviewJin : ScreenPlay
    {
        public GuildInterviewJin()
        {
            
            // Do I need the character objects here?  Or just the names?
            // Shouldn't the SceneManager initialize the character objects?
            this.CastOfCharacters = new List<string>() {
                margot, jin
            };

            this.Text = new List<Line>()
            {
                {new Line(
                    speaker: margot,
                    "Test Dialogue",
                    new List<string>() {arg1, arg2}
                )}, 
                {new Line(
                    storyText: "Test dialogue2.  Should use last speaker by default."
                )

                }
            };
        }
    }
}
