using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PopKuru.BackgroundName;

namespace PopKuru
{
    public class BackgroundImage
    {
        public BackgroundName ImageName {get; private set; }
        public string FilePath {get; private set; }

        // Stores a lookup of names with locations relative to the Resources folder.
        Dictionary<BackgroundName, string> ImagePathLookup = new Dictionary<BackgroundName, string>()
        {
            {guildHall1, "Images/Locations/GuildHall1"},
            {guildHall2, ""},
            {defaultBackground, "Images/Locations/Guildhall1"} // TODO set default image
        };

        public BackgroundImage(BackgroundName imageName)
        {
            this.ImageName = imageName;
            this.FilePath = ImagePathLookup[imageName];

            // Guard Clause: if image doesn't exist, load default instead.
            if (this.FilePath == "")
            {
                this.FilePath = ImagePathLookup[defaultBackground];
                Debug.Log("No background image file found. Reverted to default.");
            }
        }

    }
}

// Resources.Load<Sprite>(path);