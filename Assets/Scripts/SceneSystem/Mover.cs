using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public enum StagePosition
    {
        center, right, left, offStage
    }

    public static class Mover
    {
        // stage directions


        // Take a gameobject and a stage direction
        // Return new transform params
        // RectTransform.sizeDelta


        public static void MoveTo(RectTransform characterRT, StagePosition newPosition, float amount = 0.5f)
        {
            Debug.Log(characterRT.sizeDelta);
            switch (newPosition)
            {
                // get size delta
                
                case StagePosition.offStage:
                    // TODO set the character rect transform to x = sizeDelta + width of sprite
                    break;
                case StagePosition.center:
                    amount = 0f;
                    // TODO set the character rect transform to x = 0
                    break;
                case StagePosition.right:
                    // TODO set the character rect transform to x = sizeDelta - width of sprite * amount
                    break;
                case StagePosition.left:
                    // TODO set the character rect transform to x = sizeDelta - width of sprite * amount
                    break;
            };


            Debug.LogWarning("MoveTo not implemented.");
        }

        /*
                public RectTransform MoveTo(RectTransform rT, StagePosition position, float amount = 0.5f)
        {
            Debug.LogWarning("Generic MoveTo Not implemented");

            return rT;
        }

        // Overload for moving a character, specifically
        public RectTransform MoveTo(Character character, StagePosition position, float amount = 0.5f)
        {
            RectTransform rT = character.RT;
            float deltaX = rT.sizeDelta.x;

            return rT;
        }
        */
    }
}
