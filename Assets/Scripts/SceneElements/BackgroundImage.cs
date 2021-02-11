using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class BackgroundImage
    {
        public ImageNameEnum Name {get; private set; }
        public string File {get; private set; }

        // Stores a list of controlled names
        public enum ImageNameEnum
        {
            GuildHall1,
            GuildHall2
        }

        // Stores a lookup of names with locations relative to the Resources folder.
        Dictionary<ImageNameEnum, string> ImageLookup = new Dictionary<ImageNameEnum, string>()
        {
            {ImageNameEnum.GuildHall1, "Images/Locations/GuildHall1"}
        };

        public BackgroundImage(ImageNameEnum imageName)
        {
            this.Name = imageName;
            this.File = ImageLookup[imageName];
            // TODO Guard Clause: if image doesn't exist, load default instead.
        }

    }
}

// Resources.Load<Sprite>(path);