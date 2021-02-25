using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PopKuru.CharName;
using static PopKuru.CommandName;
using static PopKuru.Expression;

namespace PopKuru
{
    public abstract class ScreenPlay
    {
        public string Title {get; protected set;}

        // ScreenPlay Fields and Properties
        public List<BackgroundName> Backgrounds {get; protected set;} // TODO offload this to a location class
        public List<Line> Text {get; protected set;}
        public List<CharName> CastOfCharacters;
    }
}
