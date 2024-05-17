using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;
using System;

namespace The_Hex_Expansion
{
    public class CardsRegistration
    {
        public static Ability GetAbility(string GUID, string name)
        {
            return GuidManager.GetEnumValue<Ability>(GUID, name);
        }
        public static string Awake(int CardCount = 0)
        {
            // EightFuckingBears
            CardInfo EightFuckingBears = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Eight_Bears", "8 fucking bears!", 32, 48, description: "Kill this abomination, please.");
            EightFuckingBears.SetCost(bloodCost: 0).AddAbilities().AddSpecialAbilities().AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("eightfuckingbears.png").SetEmissivePortrait("eightfuckingbears_emissive.png").AddTribes(TheHexExpansion.SuperWeaselKid);
            CardManager.Add(TheHexExpansion.PluginPrefix, EightFuckingBears);
            CardCount++;
            // SuperWeaselKid
            CardInfo SuperWeaselKid = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Super_Weasel_Kid", "Super Weasel Kid", 2, 3, description: "Here you can Run, Jump, and maybe even soar amoung the clouds.");
            SuperWeaselKid.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Flighty")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Super_Weasel_Kid.png").SetEmissivePortrait("Super_Weasel_Kid_e.png").AddTribes(TheHexExpansion.SuperWeaselKid, TheHexExpansion.ViciousGalaxy).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode);
            CardManager.Add(TheHexExpansion.PluginPrefix, SuperWeaselKid);
            CardCount++;
            // Mr.Shrewd
            CardInfo MrShrewd = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Mr_Shrewd", "Mr. Shrewd", 2, 2, description: "I'll be looking out for you kid.");
            MrShrewd.SetCost(bloodCost: 1).AddAbilities(Ability.WhackAMole, GetAbility("nevernamed.inscryption.sigils", "Doomed")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Mr.Shrewd.png").SetEmissivePortrait("Mr.Shrewd_e.png").AddTribes(TheHexExpansion.SuperWeaselKid, TheHexExpansion.TheWalk).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode).SetExtendedProperty("CustomDoomedDuration", 3);
            CardManager.Add(TheHexExpansion.PluginPrefix, MrShrewd);
            CardCount++;
            // Mr.Squarrel
            CardInfo MrSquarrel = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Mr_Squarrel", "Mr. Squarrel", 2, 4, description: "I'll be looking out for you kid.");
            MrSquarrel.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Tempting Target")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Mr.Squarrel.png").SetEmissivePortrait("Mr.Squarrel_e.png").AddTribes(TheHexExpansion.SuperWeaselKid, TheHexExpansion.SecretsOfLegendaria).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode);
            CardManager.Add(TheHexExpansion.PluginPrefix, MrSquarrel);
            CardCount++;
            // Groonda
            CardInfo Groonda = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Groonda_", "Groonda", 1, 3, description: "A wild groonda appears, jump on it to get rid of it! But be careful, these critters can move.");
            Groonda.SetCost(bloodCost: 1).AddAbilities(Ability.Strafe, Ability.Sharp).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Groonda.png").SetEmissivePortrait("Groonda_e.png").AddTribes(TheHexExpansion.SuperWeaselKid).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode);
            CardManager.Add(TheHexExpansion.PluginPrefix, Groonda);
            CardCount++;
            // Catarina
            CardInfo Catarina = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Catarina_", "Catarina", 2, 2, description: "A wild groonda appears, jump on it to get rid of it! But be careful, these critters can move.");
            Catarina.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Downdraft"), Ability.Flying).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Catarina.png").SetEmissivePortrait("Catarina_e.png").AddTribes(TheHexExpansion.SuperWeaselKid, TheHexExpansion.TheWalk).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode);
            CardManager.Add(TheHexExpansion.PluginPrefix, Catarina);
            CardCount++;

            return CardCount.ToString();
        }
    }
}