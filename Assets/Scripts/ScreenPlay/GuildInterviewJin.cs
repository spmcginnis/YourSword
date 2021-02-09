using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class GuildInterviewJin : ScreenPlay
    {
        public GuildInterviewJin()
        {
            this.Title = "Guild Interview with Jin.";   
            this.BackgroundImagePaths = new Dictionary<string, string>()
            {
                {"TestBackgroundName", "TestBackgroundURL"} //TEMP
            };
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
