using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class Character
    {
        public string Name { get; private set; }
        public List<ImageSet> ImageSetList = new List<ImageSet>();

        public Character(string name)
        {
            // Initialize Name
            this.Name = name;

            // Initialize Image Index for that name
            ImageSetList = ImageSet.InitializeImageSets(name);
            
        }
 
    }
}
