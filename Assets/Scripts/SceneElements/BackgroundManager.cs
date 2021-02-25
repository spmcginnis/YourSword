using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PopKuru.BackgroundName;

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

        public void LoadBackground(BackgroundName imageName, float opacity = 0.8f)
        {
            Color adjusted = new Color (1f, 1f, 1f, a:opacity);
            BackgroundImageComponent.color = adjusted;
            
            BackgroundImage image = new BackgroundImage(imageName); // TEMP // TODO move this to a list and draw from the list, updating when necessary.  Maybe scene manager does need to load backgrounds?
            BackgroundImageComponent.sprite = Resources.Load<Sprite>(image.FilePath);
        }
    }
}
