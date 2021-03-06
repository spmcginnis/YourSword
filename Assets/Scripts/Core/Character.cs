using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PopKuru.CharName;
using static PopKuru.Expression;

namespace PopKuru
{
    public class Character
    {
        public CharName Name { get; private set; }       

        // Unity Game Object references
        public RectTransform RT {get; set;} // TODO change to private set and building by constructor.  See notes in SceneManager.
        public RectTransform FaceRT {get; set;}
        public RectTransform BodyRT {get; set;}

        // FilePaths
        string Root = "Images/Characters";
        string Path;

        public Character(CharName charName, RectTransform rT)
        {
            // Initialize Name
            this.Name = charName;
            this.RT = rT;
            SetPath(charName);
        }

        void SetPath(CharName charName)
        {
            this.Path = Root;
            switch (charName)
            {
                case margot:
                    this.Path += "/Margot";
                    break;
                case jin:
                    this.Path += "/Jin";
                    break;
            }
        }
        // change expression // needs recttransform, filepath
        public void ChangeExpression(Expression expression) // TODO add transition effects
        {

        }
    }
}
