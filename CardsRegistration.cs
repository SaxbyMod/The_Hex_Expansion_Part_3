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
            /* EightFuckingBears
            CardInfo EightFuckingBears = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Eight_Bears", "8 fucking bears!", 32, 48, description: "Kill this abomination, please.");
            EightFuckingBears.SetCost(bloodCost: 0).AddAbilities().AddSpecialAbilities().AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("eightfuckingbears.png").SetEmissivePortrait("eightfuckingbears_emissive.png").AddTribes(TheHexExpansion.SuperWeaselKid);
            CardManager.Add(TheHexExpansion.PluginPrefix, EightFuckingBears);
            CardCount++;
            */
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
            CardInfo MrSquarrel = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Mr_Squarrel", "Mr. Squarrel", 1, 4, description: "I'll be looking out for you kid.");
            MrSquarrel.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Tempting Target")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Mr.Squarrel.png").SetEmissivePortrait("Mr.Squarrel_e.png").AddTribes(TheHexExpansion.SuperWeaselKid, TheHexExpansion.SecretsOfLegendaria).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode);
            CardManager.Add(TheHexExpansion.PluginPrefix, MrSquarrel);
            CardCount++;
            // Groonda
            CardInfo Groonda = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Groonda_", "Groonda", 1, 3, description: "A wild groonda appears, jump on it to get rid of it! But be careful, these critters can move.");
            Groonda.SetCost(bloodCost: 1).AddAbilities(Ability.Strafe, Ability.Sharp).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Groonda.png").SetEmissivePortrait("Groonda_e.png").AddTribes(TheHexExpansion.SuperWeaselKid).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode).SetTraits(Trait.KillsSurvivors);
            CardManager.Add(TheHexExpansion.PluginPrefix, Groonda);
            CardCount++;
            // Catarina
            CardInfo Catarina = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Catarina_", "Catarina", 2, 2, description: "Bring me 50, and to you a secret I will reveal.");
            Catarina.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Downdraft"), Ability.Flying).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Catarina.png").SetEmissivePortrait("Catarina_e.png").AddTribes(TheHexExpansion.SuperWeaselKid, TheHexExpansion.TheWalk).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode).SetDefaultEvolutionName("This game was built on the ashes of another.");
            CardManager.Add(TheHexExpansion.PluginPrefix, Catarina);
            CardCount++;
            // Cloud
            CardInfo Cloud = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Cloud_", "Cloud", 1, 2, description: "A giggling cloud I don't know why it's around, maybe it can be used as a stepping stone?");
            Cloud.SetCost(bloodCost: 0).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Obedient"), Ability.Flying).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Cloud.png").SetEmissivePortrait("Cloud_e.png").AddTribes(TheHexExpansion.SuperWeaselKid).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode);
            CardManager.Add(TheHexExpansion.PluginPrefix, Cloud);
            CardCount++;
            // Death
            CardInfo Death = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Death_", "Death", 1, 3, description: "Be careful, one wrong move and it will obliterate everything.");
            Death.SetCost(bloodCost: 1).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Annihilation"), GetAbility("creator.TooManySigils", "Rotting"), GetAbility("nevernamed.inscryption.sigils", "Vampiric"), Ability.GainAttackOnKill).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Death.png").SetEmissivePortrait("Death_e.png").AddTribes(TheHexExpansion.SuperWeaselKid).AddMetaCategories(CardMetaCategory.Rare);
            CardManager.Add(TheHexExpansion.PluginPrefix, Death);
            CardCount++;
            // Hill
            CardInfo Hill = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Hill_", "Hill", 0, 5, description: "A hill cursed to bleed for eternity, due to the purcha- No, due to Lou Natas.");
            Hill.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Twin Bond"), GetAbility("nevernamed.inscryption.sigils", "Tempting Target")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Hill.png").SetEmissivePortrait("Hill_e.png").AddTribes(TheHexExpansion.SuperWeaselKid).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode);
            CardManager.Add(TheHexExpansion.PluginPrefix, Hill);
            CardCount++;
            // Bryce
            CardInfo Bryce = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Bryce_", "Bryce", 1, 2, description: "This is ridiculous, I'm from a cooking game.");
            Bryce.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Bandage Weaver"), GetAbility("nevernamed.inscryption.sigils", "Chaos Strike")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Bryce.png").SetEmissivePortrait("Bryce_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode);
            CardManager.Add(TheHexExpansion.PluginPrefix, Bryce);
            CardCount++;
            // Bhakto
            CardInfo Bhakto = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Bhakto_", "Bhakto", 1, 2, description: "You have heard of Bhakto, No? He is a decendant of the great Mi Singh.");
            Bhakto.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Double Tap"), Ability.Sniper).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Bhakto.png").SetEmissivePortrait("Bhakto_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode);
            CardManager.Add(TheHexExpansion.PluginPrefix, Bhakto);
            CardCount++;
            // Mi Singh
            CardInfo MiSingh = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Mi_Singh", "Mi Singh", 2, 3, description: "Match my fists young one.");
            MiSingh.SetCost(bloodCost: 2, bonesCost: 3).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Commander"), GetAbility("creator.TooManySigils", "Rotting"), GetAbility("nevernamed.inscryption.sigils", "Herald")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Mi_Singh.png").SetEmissivePortrait("Mi_Singh_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.Rare);
            CardManager.Add(TheHexExpansion.PluginPrefix, MiSingh);
            CardCount++;
            // Alley Gator
            CardInfo AlleyGator = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Alley_Gator", "Alley Gator", 2, 2, description: "What next a crocadil- What u $%^@ say m8? I'm a %^*# alligator m8, say it.");
            AlleyGator.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Ravenous")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Alley_Gator.png").SetEmissivePortrait("Alley_Gator_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer);
            CardManager.Add(TheHexExpansion.PluginPrefix, AlleyGator);
            CardCount++;
            // Steamboat Willy
            CardInfo SteamboatWilly = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Steamboat_Willy", "Steamboat Willy", 2, 2, description: "ACTIVATING STEAM PROTOCALS. PREPARE FOR COMBAT NON-BOAT CREATURE. GETTING STEAMY ULTIMATE ABILITY PREPARED.");
            SteamboatWilly.SetCost(energyCost: 6).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Trampler"), GetAbility("nevernamed.inscryption.sigils", "Mauler"), Ability.DeathShield).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Steamboat_Willy.png").SetEmissivePortrait("Steamboat_Willy_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer);
            CardManager.Add(TheHexExpansion.PluginPrefix, SteamboatWilly);
            CardCount++;
            // Granny
            CardInfo Granny = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Granny_", "Granny", 0, 3, description: "An excellent idea Bryce, You still remember how to bake my pies right?");
            Granny.SetCost(bloodCost: 1).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Medicinal"), GetAbility("nevernamed.inscryption.sigils", "Bandage Weaver")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Granny.png").SetEmissivePortrait("Granny_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer);
            CardManager.Add(TheHexExpansion.PluginPrefix, Granny);
            CardCount++;
            // Shinobi
            CardInfo Shinobi = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Shinobi_", "Shinobi", 1, 3, description: "This shinobi leaps rooftop to rooftop, looking for something no one knows why. Anyone who gets in their way is executed.");
            Shinobi.SetCost(bloodCost: 1).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Morph Mover"), Ability.Deathtouch).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Shinobi.png").SetEmissivePortrait("Shinobi_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.Rare);
            CardManager.Add(TheHexExpansion.PluginPrefix, Shinobi);
            CardCount++;
            // Maniacus
            CardInfo Maniacus = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Maniacus_", "Maniacus", 3, 2, description: "Maniacus, the hellbent striker, always striking opposite directions after he attacks, to ensure his victims aren't able to predict his moves.");
            Maniacus.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Wavering Strike")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Maniacus.png").SetEmissivePortrait("Maniacus_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer);
            CardManager.Add(TheHexExpansion.PluginPrefix, Maniacus);
            CardCount++;
            // Theodore
            CardInfo Theodore = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Theodore_", "Theodore", 2, 3, description: "The crusader has arrived, trying to prevent the spread of fighting by fighting.");
            Theodore.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Wavering Strike"), GetAbility("nevernamed.inscryption.sigils", "Return Strike")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Theodore.png").SetEmissivePortrait("Theodore_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.Rare);
            CardManager.Add(TheHexExpansion.PluginPrefix, Theodore);
            CardCount++;
            // Flinton
            CardInfo Flinton = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Flinton_", "Flinton", 1, 2, description: "An alien has come down to earth to beat some people's faces up and blast a ruby ray through their skulls.");
            Flinton.SetCost(bloodCost: 1).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Wavering Strike"), Ability.Deathtouch).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Flinton.png").SetEmissivePortrait("Flinton_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer);
            CardManager.Add(TheHexExpansion.PluginPrefix, Flinton);
            CardCount++;
            // Magnus
            CardInfo Magnus = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Magnus_", "Magnus", 3, 1, description: "Crunches through the bones of weak foes, If I were you I would stay out of his way!");
            Magnus.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Bully")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Magnus.png").SetEmissivePortrait("Magnus_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer);
            CardManager.Add(TheHexExpansion.PluginPrefix, Magnus);
            CardCount++;
            // Astrid
            CardInfo Astrid = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Astrid_", "Astrid", 1, 2, description: "An heir of the sky, a kin of the almighty Zeus, they are in charge of keeping life's balance proper.");
            Astrid.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Preemptive Strike"), GetAbility("nevernamed.inscryption.sigils", "Swooping Strike")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Astrid.png").SetEmissivePortrait("Astrid_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer);
            CardManager.Add(TheHexExpansion.PluginPrefix, Astrid);
            CardCount++;
            // Irving
            CardInfo Irving = CardManager.New(modPrefix: TheHexExpansion.PluginPrefix, "Irving_", "Irving", 2, 2, description: "The unfair judge, enforcer, and lawmaker of the universe. One wrong move and your out!");
            Irving.SetCost(bloodCost: 2).AddAbilities(GetAbility("nevernamed.inscryption.sigils", "Bully"), GetAbility("nevernamed.inscryption.sigils", "Bloodrunner"), GetAbility("nevernamed.inscryption.sigils", "Trophy Hunter")).AddAppearances(TheHexExpansion.TheHexCardbackAppearence).SetPortrait("Irving.png").SetEmissivePortrait("Irving_e.png").AddTribes(TheHexExpansion.CombatArenaX).AddMetaCategories(CardMetaCategory.Rare);
            CardManager.Add(TheHexExpansion.PluginPrefix, Irving);
            CardCount++;

            return CardCount.ToString();
        }
    }
}