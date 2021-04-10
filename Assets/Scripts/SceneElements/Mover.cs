using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{


    public class Mover
    {
        float ScreenWidth;
        // TODO deal with the possibility that the screen may change size during game play.

        public Mover(float screenWidth)
        {
            ScreenWidth = screenWidth;
        }

        public void ReSize(float newWidth)
        {
            ScreenWidth = newWidth;
        }

        // TODO // deal with placing more than one character on the same side of the screen
        // it will calculate the position on the screen based on the number of characters on that side of the screen
        // will it reposition existing characters or just put the new one in place in some kind of set order.
        // [.5f, .33f, .66f, .2f, .8f, .125f, .875f]
        public void MoveTo(RectTransform RT, StagePosition newPosition, int numCharacters = 0)
        {
            float spriteWidth = RT.sizeDelta.x;
            float margin = (ScreenWidth - spriteWidth) / 2;
            float distance;
            float[] scale = new float[]{.5f, .33f, .66f, .2f, .8f, .125f, .875f};
            switch (newPosition)
            {
                case StagePosition.offStage:
                    RT.anchoredPosition = new Vector2(0f, -10000f);
                    break;
                case StagePosition.center:
                    RT.anchoredPosition = new Vector2(0f, 0f);
                    break;
                case StagePosition.right:
                    distance = margin * scale[numCharacters];
                    RT.anchoredPosition = new Vector2(distance, 0f);
                    break;
                case StagePosition.left:
                    distance = margin * scale[numCharacters];
                    RT.anchoredPosition = new Vector2(-distance, 0f);
                    break;
            };
        }



        // TODO Overloads for moving objects that don't have recttransforms // YAGNI?

    }
}
