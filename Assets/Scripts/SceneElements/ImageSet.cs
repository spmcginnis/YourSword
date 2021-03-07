using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class ImageSet // NOT IN USE
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

       public static List<ImageSet> InitializeImageSets(string name)
        {
            List<ImageSet> ImageSetList = new List<ImageSet>();
            switch (name.ToLower())
            {
                case "margot":
                    string body1 = "test body URL";
                    Dictionary<string, string> faceList1 = new Dictionary<string, string>()
                    {
                        {"smile", "test smile URL"}
                        // Add more pairs for the expressions that go with that same body pose
                    };
                    string poseName = "Standard Pose";
                    ImageSetList.Add(new ImageSet(bodyURL:body1, faceList:faceList1, indexOf:poseName));
                    break;
                // default: create a blank character image set for default fallback and testing purposes.  silhoutte with question mark face.
                
            }

            return ImageSetList;
        }


    }
}
