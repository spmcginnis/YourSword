using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PopKuru
{
    public class BackgroundManager
    {
        GameObject BackgroundPanel;
        Image BackgroundImageComponent;

        public BackgroundManager(GameObject backgroundPanel)
        {
            BackgroundPanel = backgroundPanel;
            BackgroundImageComponent = BackgroundPanel.transform.Find("Image").GetComponent<Image>();
        }

        public void LoadBackground(BackgroundImage image, float opacity = -1f)
        {
            if (opacity >= -0.5f)
            {
                Color adjusted = new Color (1f, 1f, 1f, a:opacity);
                BackgroundImageComponent.color = adjusted;
            }

            BackgroundImageComponent.sprite = Resources.Load<Sprite>(image.FilePath);



        }
    }
}
