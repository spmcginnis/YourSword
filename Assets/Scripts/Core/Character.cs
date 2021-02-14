using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class Character
    {
        public CharName Name { get; private set; }
               
        public List<ImageSet> ImageSetList = new List<ImageSet>();

        // Unity Game Object references

        public RectTransform RT {get; set;}

        public Character(CharName name)
        {
            // Initialize Name
            this.Name = name;

            // Initialize Image Index for that name
            ImageSetList = ImageSet.InitializeImageSets(name.ToString("g"));


        }
    }
}
