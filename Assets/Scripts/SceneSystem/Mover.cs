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

        // TODO deal with the possibility that the screen may change size during game play.
        float screenWidth; // TEMP // TODO calculate the width of the screen

        // TODO properties to store data from the current canvas
        public Mover(float screenWidth)
        {
            // TODO get the dimensions of the canvas at init
            this.screenWidth = screenWidth;
        }

        public void MoveTo(RectTransform RT, StagePosition newPosition, float scale = 0.5f)
        {
            Debug.Log("Size delta: " + RT.sizeDelta);
            Debug.Log("Sprite Width " + RT.sizeDelta);
            Debug.Log("CP width " + screenWidth);
            float spriteWidth = RT.sizeDelta.x;
            float margin = (screenWidth - spriteWidth) / 2;
            float distance;
            switch (newPosition)
            {
                // get size delta
                
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

            Debug.Log("anchoredPosition" + RT.anchoredPosition);

        }

        // Overloads for moving objects that don't have recttransforms

    }
}
