using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class Character
    {
        public string Name { get; private set; }
        public List<ImageSet> PoseSets = new List<ImageSet>();

        public Character(string name)
        {
            // Initialize Name
            this.Name = name;

            // Initialize Image Index for that name
            InitializeImageSets(name);

            Debug.Log($"Character object for {this.Name} initialized. {this.PoseSets[0].IndexOf} image set: {this.PoseSets[0].Body}, {this.PoseSets[0].FaceList["smile"]}.");
        }

        public class ImageSet 
        {
            public string IndexOf { get; private set;}
            public string Body { get; private set; }
            public Dictionary<string, string> FaceList { get; private set; }

            public ImageSet(string bodyURL, Dictionary<string, string> faceList, string indexOf = "default image" )
            {
                this.IndexOf = indexOf;
                this.Body = bodyURL;
                this.FaceList = faceList;
            }
        }

        private void InitializeImageSets(string name)
        {
          switch (name.ToLower())
            {
                case "margot":
                    string body1 = "test body URL";
                    Dictionary<string, string> faceList1 = new Dictionary<string, string>()
                    {
                        {"smile", "test smile URL"}
                    };
                    string poseName = "Standard Pose";
                    PoseSets.Add(new ImageSet(bodyURL:body1, faceList:faceList1, indexOf:poseName));
                    break;
            }
        }
    }
}
