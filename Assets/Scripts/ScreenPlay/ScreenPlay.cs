using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public abstract class ScreenPlay
    {
        public string Title {get; protected set;}

        // Full List of Names -> enum (?)
        protected const string margot = "Margot";
        protected const string jin = "Jin";

        // Full List of Args -> enum (?)
        protected const string arg1 = "test arg1";
        protected const string arg2 = "test arg2";


        // ScreenPlay Fields and Properties
        public Dictionary<string, string> BackgroundImagePaths {get; protected set;} // TODO offload this to a location class
        public List<Line> Text {get; protected set;}
        public List<string> CastOfCharacters;

        public class Line
        {
            public string Speaker {get; protected set;}
            public string StoryText {get; protected set;}
            public List<string> Args {get; protected set;}
            string LastSpeaker = "";

            public Line(string speaker = "", string storyText = "",  List<string> Args = null)
            {
                if (speaker == "")
                {
                    this.Speaker = this.LastSpeaker;
                }
                
                this.Speaker = speaker;
                this.StoryText = storyText;
                this.Args = Args;
                this.LastSpeaker = speaker;
            }
        }

    }
}
