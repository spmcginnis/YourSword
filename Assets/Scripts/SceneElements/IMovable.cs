using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public enum StagePosition
    {
        center, right, left, offStage
    }

    public interface IMovable<T, X, Y>
    {
        // stage directions


        // Take a gameobject and a stage direction
        // Return new transform params
        // RectTransform.sizeDelta

        public void MoveTo(T RectTransform, X StagePosition, Y FloatAmount);

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
