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

        public Character(CharName charName, GameObject prefab)
        {          
            // Initialize Name
            this.Name = charName;
            this.Prefab = prefab;
            this.RT = this.Prefab.GetComponent<RectTransform>();
            
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
        public void ChangeExpression(Expression expression) // TODO add transition effects
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
            }

        }

    }
}
