using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class Character : IMovable<RectTransform, StagePosition, float>
    {
        public string Name { get; private set; }
        public List<ImageSet> ImageSetList = new List<ImageSet>();

        // Unity Game Object references

        public RectTransform CharacterPrefabRT {get; private set;}

        public Character(string name)
        {
            // Initialize Name
            this.Name = name;

            // Initialize Image Index for that name
            ImageSetList = ImageSet.InitializeImageSets(name);



        }



        public void MoveTo(RectTransform characterRT, StagePosition newPosition, float amount = 0.5f)
        {   
            if (newPosition == StagePosition.center)
            {
                amount = 0f;
                // TODO set the character rect transform to x = 0
            }

            Debug.LogWarning("MoveTo not implemented.");
        }

        //TODO Calculate relative position
        
 
    }
}
