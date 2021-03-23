using System.Collections;
using System.Collections.Generic;
using static PopKuru.CharName;

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

    // Checklist
        // Auden // standards done
        // Jin // need update for standard expressions
        // Margot // need update for standard expresssions
        // Salvador // standards done
        // Greylin // Standards done
        // Lua // standards done
        // Cassandra // standards done

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
        const string RootPath = "Images/Characters/";
        public static Dictionary<CharName, string> Thumbnail =
            new Dictionary<CharName, string>
            {
                [auden] = RootPath + "Auden/AudenThumbnail",
                [cassandra] = RootPath + "Cassandra/CassandraThumbnail",
                [greylin] = RootPath + "Greylin/GreylinThumbnail",
                [jin] = RootPath + "Jin/JinThumbnail",
                [lua] = RootPath + "Lua/LuaThumbnail",
                [margot] = RootPath + "Margot/MargotThumbnail",
                [salvador] = RootPath + "Salvador/SalvadorThumbnail"
            };

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
                },
                [Expression.neutral] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalCalmEyes"
                },
                [Expression.cheerful] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalFriendlyBlink"
                },
                [Expression.annoyed] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalSkeptical"
                },
                [Expression.soft] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalSmileBlink"
                },
                [Expression.sad] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalSkeptical"
                },
                [Expression.tearful] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalSkeptical"
                },
                [Expression.surprised] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalSurprised"
                },
                [Expression.angry] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalAngry"
                },
                [Expression.blushing] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalAnxiousLaugh"
                },
                [Expression.superblushing] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalAnxiousLaugh"
                },
                [Expression.flirty] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalSmirkWink"
                },
                [Expression.confused] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Salvador/SalAnxiousLaugh"
                }
            };

        public static Dictionary<Expression, Dictionary<string, string>> Auden =
            new Dictionary<Expression, Dictionary<string, string>>
            {
                [Expression.starting] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakSkeptical"
                },
                [Expression.neutral] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakFrown"
                },
                [Expression.cheerful] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakCrazyEyed"
                },
                [Expression.annoyed] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakAnnoyed"
                },
                [Expression.soft] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakSideSmile"
                },
                [Expression.sad] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakGrumpy"
                },
                [Expression.tearful] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakGrumpy"
                },
                [Expression.surprised] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakCrazyEyed"
                },
                [Expression.angry] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakMoreAngry"
                },
                [Expression.blushing] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakBlushing"
                },
                [Expression.superblushing] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakBlushing"
                },
                [Expression.flirty] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakSideSmile"
                },
                [Expression.confused] = new Dictionary<string, string>
                {
                    ["Body"] = BlankSprite,
                    ["Face"] = "Images/Characters/Auden/AudenCloakSkeptical"
                }
            };
        
        public static Dictionary<Expression, Dictionary<string, string>> Lua =
            new Dictionary<Expression, Dictionary<string, string>>
            {
                [Expression.starting] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody2b",
                    ["Face"] = "Images/Characters/Lua/LuaBody2bWarm"
                },
                [Expression.neutral] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody1a",
                    ["Face"] = "Images/Characters/Lua/LuaBody1Warm"
                },
                [Expression.cheerful] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody2b",
                    ["Face"] = "Images/Characters/Lua/LuaBody2bHappy"
                },
                [Expression.annoyed] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody1b",
                    ["Face"] = "Images/Characters/Lua/LuaBody1FaceDetermined"
                },
                [Expression.soft] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody1a",
                    ["Face"] = "Images/Characters/Lua/LuaBody1FaceAroused"
                },
                [Expression.sad] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody2a",
                    ["Face"] = "Images/Characters/Lua/LuaBody2Sad"
                },
                [Expression.tearful] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody1a",
                    ["Face"] = "Images/Characters/Lua/LuaBody1FaceBlushingCry"
                },
                [Expression.surprised] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody1a",
                    ["Face"] = "Images/Characters/Lua/LuaBody1FaceSurprised"
                },
                [Expression.angry] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody2a",
                    ["Face"] = "Images/Characters/Lua/LuaBody2bAngry"
                },
                [Expression.blushing] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody1a",
                    ["Face"] = "Images/Characters/Lua/LuaBody1FaceBlushingSmile"
                },
                [Expression.superblushing] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody2a",
                    ["Face"] = "Images/Characters/Lua/LuaBody2bEmbarrassed"
                },
                [Expression.flirty] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody2b",
                    ["Face"] = "Images/Characters/Lua/LuaBody2bHappy"
                },
                [Expression.confused] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Lua/LuaBody1a",
                    ["Face"] = "Images/Characters/Lua/LuaBody1FaceBlush"
                }
            };

            public static Dictionary<Expression, Dictionary<string, string>> Greylin =
            new Dictionary<Expression, Dictionary<string, string>>
            {
                [Expression.starting] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1Frown"
                },
                [Expression.neutral] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1Frown"
                },
                [Expression.cheerful] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1Smile"
                },
                [Expression.annoyed] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1FrownBlink"
                },
                [Expression.soft] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1Smile"
                },
                [Expression.sad] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1FrownBlink"
                },
                [Expression.tearful] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1FrownBlink"
                },
                [Expression.surprised] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1Smile"
                },
                [Expression.angry] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1FrownBlink"
                },
                [Expression.blushing] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1FrownBlushBlink"
                },
                [Expression.superblushing] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1FrownBlushBlink"
                },
                [Expression.flirty] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1FrownBlush"
                },
                [Expression.confused] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Greylin/GreylinBody1",
                    ["Face"] = "Images/Characters/Greylin/GreylinBody1FrownBlink"
                }
            };
            
            public static Dictionary<Expression, Dictionary<string, string>> Cassandra =
            new Dictionary<Expression, Dictionary<string, string>>
            {
                [Expression.starting] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Cool"
                },
                [Expression.neutral] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Cool"
                },
                [Expression.cheerful] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Cool"
                },
                [Expression.annoyed] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Wince"
                },
                [Expression.soft] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Cool"
                },
                [Expression.sad] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Wince"
                },
                [Expression.tearful] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Wince"
                },
                [Expression.surprised] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Wince"
                },
                [Expression.angry] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Wince"
                },
                [Expression.blushing] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Blush"
                },
                [Expression.superblushing] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Blush"
                },
                [Expression.flirty] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Blush"
                },
                [Expression.confused] = new Dictionary<string, string>
                {
                    ["Body"] = "Images/Characters/Cassandra/CassandraBody1",
                    ["Face"] = "Images/Characters/Cassandra/CassandraBody1Wince"
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
