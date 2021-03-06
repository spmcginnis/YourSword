using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static PopKuru.CharName;
using static PopKuru.Expression;

namespace PopKuru
{
    public class Character
    {
        public CharName Name { get; private set; }       

        // Unity Game Object references
        GameObject Prefab;
        public RectTransform RT {get; private set;}
        Image Face;
        Image Body;
        public Sprite Thumbnail {get; private set;}

        public Character(CharName charName, GameObject prefab, Sprite thumbnail)
        {          
            // Initialize Name
            this.Name = charName;
            this.Prefab = prefab;
            this.RT = this.Prefab.GetComponent<RectTransform>();
            this.Thumbnail = thumbnail;
            
            Image[] imageComps = Prefab.GetComponentsInChildren<Image>();
            this.Body = imageComps[0];
            this.Face = imageComps[1];
            // Component[] components = temp.GetComponents(typeof(Component));
            // foreach(Component component in components)
            // {
            //     Debug.Log("Components on BodyImage: " + component.ToString());
            // }
            ChangeExpression(starting);
        }
        
        

        // change expression // needs image hook and filepath
        public void ChangeExpression(Expression expression) // TODO add transition effects // Is the switch case necessary?  There should be a way to avoid it now.
        {
            switch (this.Name)
            {
                case (margot):
                    this.Body.sprite = Resources.Load<Sprite>(ExpressionLookup.Margot[expression]["Body"]);
                    this.Face.sprite = Resources.Load<Sprite>(ExpressionLookup.Margot[expression]["Face"]);
                    break;
                case (jin):
                    this.Body.sprite = Resources.Load<Sprite>(ExpressionLookup.Jin[expression]["Body"]);
                    this.Face.sprite = Resources.Load<Sprite>(ExpressionLookup.Jin[expression]["Face"]);
                    break;
                case (cassandra):
                    this.Body.sprite = Resources.Load<Sprite>(ExpressionLookup.Cassandra[expression]["Body"]);
                    this.Face.sprite = Resources.Load<Sprite>(ExpressionLookup.Cassandra[expression]["Face"]);
                    break;
                case (lua):
                    this.Body.sprite = Resources.Load<Sprite>(ExpressionLookup.Lua[expression]["Body"]);
                    this.Face.sprite = Resources.Load<Sprite>(ExpressionLookup.Lua[expression]["Face"]);
                    break;
                case (greylin):
                    this.Body.sprite = Resources.Load<Sprite>(ExpressionLookup.Greylin[expression]["Body"]);
                    this.Face.sprite = Resources.Load<Sprite>(ExpressionLookup.Greylin[expression]["Face"]);
                    break;
                case (auden):
                    this.Body.sprite = Resources.Load<Sprite>(ExpressionLookup.Auden[expression]["Body"]);
                    this.Face.sprite = Resources.Load<Sprite>(ExpressionLookup.Auden[expression]["Face"]);
                    break;
                case (salvador):
                    this.Body.sprite = Resources.Load<Sprite>(ExpressionLookup.Salvador[expression]["Body"]);
                    this.Face.sprite = Resources.Load<Sprite>(ExpressionLookup.Salvador[expression]["Face"]);
                    break;                                          
            }

        }

    }
}
