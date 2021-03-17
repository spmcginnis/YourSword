using System.Collections;
using System.Collections.Generic;
namespace PopKuru
{
    // Shared expressions according to google doc.  Check for updates.
    // neutral
    // cheerful
    // annoyed
    // soft
    // sad
    // tearful
    // surprised
    // angry
    // blushing
    // superblushing
    // flirty
    // confused
    // starting // the default


    public enum Expression
    {
        starting,
        pleasant,
        impassive,
        grouchy,
        smug,
        startled,
        smirk,
        blush,
        skeptical,
        disgusted, // TODO This line and above are from the test chapter, and will need to be changed.
        neutral,
        cheerful,
        annoyed,
        sad,
        tearful,
        surprised,
        angry,
        blushing,
        superblushing,
        flirty,
        confused,
        eyebrowpop,
        toothy,
        catecstacy,
        eager,
        lipbite,
        sarcastic,
        soft
    }

    public static class ExpressionLookup
    {
        const string BlankSprite = "Images/BlankSprite";

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
                    ["Face"] = "Images/Characters/Margot/MargotBody1Smile"
                },
                [Expression.disgusted] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Margot/MargotBody1Template",
                    ["Face"] = "Images/Characters/Margot/MargotBody1Concerned2"
                },
                [Expression.grouchy] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Margot/MargotBody1Template",
                    ["Face"] = "Images/Characters/Margot/MargotBody1Exasperated"
                },
                [Expression.startled] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Margot/MargotBody1Template",
                    ["Face"] = "Images/Characters/Margot/MargotBody1Concerned2"
                },
                [Expression.angry] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Margot/MargotBody1Template",
                    ["Face"] = "Images/Characters/Margot/MargotBody1Exasperated"
                },
                [Expression.impassive] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Margot/MargotBody1Template",
                    ["Face"] = "Images/Characters/Margot/MargotBody1FriendlyBlink"
                },
                [Expression.sarcastic] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Margot/MargotBody1Template",
                    ["Face"] = "Images/Characters/Margot/MargotBody1FriendlyBlinkSmile"
                },
                [Expression.blush] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Margot/MargotBody1Template",
                    ["Face"] = "Images/Characters/Margot/MargotBody1SmileBlink"
                },
                [Expression.skeptical] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Margot/MargotBody1Template",
                    ["Face"] = "Images/Characters/Margot/MargotBody1Concerned1"
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
                    ["Face"] = "Images/Characters/Jin/Jin1FaceSmile"
                },
                [Expression.impassive] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Jin/Jin1Body",
                    ["Face"] = "Images/Characters/Jin/Jin1FaceFrownBlink"
                },
                [Expression.smug] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Jin/Jin1Body",
                    ["Face"] = "Images/Characters/Jin/Jin1FaceSmileBlink"
                },
                [Expression.grouchy] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Jin/Jin1Body",
                    ["Face"] = "Images/Characters/Jin/Jin1FaceFrown"
                },
                [Expression.smirk] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Jin/Jin1Body",
                    ["Face"] = "Images/Characters/Jin/Jin1FaceSmile"
                }
            };
        public static Dictionary<Expression, Dictionary<string, string>> Salvador =
            new Dictionary<Expression, Dictionary<string, string>>
            {
                [Expression.starting] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalFriendlyBlink"
                }
            };
        
        public static Dictionary<Expression, Dictionary<string, string>> Template =
            new Dictionary<Expression, Dictionary<string, string>>
            {
                [Expression.starting] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.neutral] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.cheerful] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.annoyed] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.soft] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.sad] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.tearful] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.surprised] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.angry] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.blushing] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.superblushing] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.flirty] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                },
                [Expression.confused] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = BlankSprite
                }
            };
    }
}
