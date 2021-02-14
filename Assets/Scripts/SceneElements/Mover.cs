using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public enum StagePosition
    {
        center, right, left, offStage
    }

    public class Mover
    {
        float screenWidth;
        // TODO deal with the possibility that the screen may change size during game play.

        public Mover(float screenWidth)
        {
            this.screenWidth = screenWidth;
        }

        public void MoveTo(RectTransform RT, StagePosition newPosition, float scale = 0.5f)
        {
            float spriteWidth = RT.sizeDelta.x;
            float margin = (screenWidth - spriteWidth) / 2;
            float distance;
            switch (newPosition)
            {
                case StagePosition.offStage:
                    distance = screenWidth + spriteWidth;
                    RT.anchoredPosition = new Vector2(distance, 0f);
                    break;
                case StagePosition.center:
                    RT.anchoredPosition = new Vector2(0f, 0f);
                    scale = 0f;
                    break;
                case StagePosition.right:
                    distance = margin * scale;
                    RT.anchoredPosition = new Vector2(distance, 0f);
                    break;
                case StagePosition.left:
                    distance = margin * scale;
                    RT.anchoredPosition = new Vector2(-distance, 0f);
                    break;
            };
        }

        // TODO Overloads for moving objects that don't have recttransforms

    }
}
