using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class CutScene : Scene
    {
        public CutScene(bool isIntro = false, bool isEnding = false)
        {
            if (isIntro||isEnding) {
                this.Menu = new StartMenu();
            } else {
                this.Menu = new GameMenu();
            }

            this.SceneType = "CutScene";
        }

        // Functionality
            // Skip CutScene with Confirmation
            // Replay CutScene

    }
}
