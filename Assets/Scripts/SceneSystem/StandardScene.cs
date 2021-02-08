using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class StandardScene : Scene
    {
        public StandardScene()
        {
            this.SceneType = "Standard";
            this.Menu = new GameMenu();
        }
    }
}
