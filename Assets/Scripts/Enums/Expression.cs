using System.Collections;
using System.Collections.Generic;
namespace PopKuru
{
    public enum Expression
    {
        starting,
        pleasant,
        sarcastic,
        impassive,
        grouchy,
        smug,
        startled,
        angry,
        smirk,
        blush,
        skeptical,
        disgusted
    }

    public static class ExpressionLookup
    {
        public static Dictionary<Expression, Dictionary<string, string>> Margot =
            new Dictionary<Expression, Dictionary<string, string>>
            {
                [Expression.starting] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Margot/MargotBody1Template",
                    ["Face"] = "Images/Characters/Margot/MargotBody1Smile"
                },
                [Expression.pleasant] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Margot/MargotBody1Template",
                    ["Face"] = "Images/Characters/Margot/MargotBody1FriendlyBlinkSmile"
                }

            };
        public static Dictionary<Expression, Dictionary<string, string>> Jin =
            new Dictionary<Expression, Dictionary<string, string>>
            {
                [Expression.starting] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Jin/Jin1Body",
                    ["Face"] = "Images/Characters/Jin/Jin1FaceSmile"
                },
                [Expression.pleasant] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Jin/Jin1Body",
                    ["Face"] = "Images/Characters/Jin/Jin1FaceSmileBlink"
                }
            };
    }
}
