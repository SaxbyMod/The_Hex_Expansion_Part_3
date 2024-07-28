using BepInEx;
using BepInEx.Bootstrap;
using DiskCardGame;
using EasyFeedback.APIs;
using HarmonyLib;
using Infiniscryption.PackManagement;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using NevernamedsSigils;
using Pixelplacement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace The_Hex_Expansion
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("zorro.inscryption.infiniscryption.packmanager", BepInDependency.DependencyFlags.SoftDependency)]

    public class TheHexExpansion : BaseUnityPlugin
    {
        // --------------------------------------------------------------------------------------------------------------------------------------------------

        // Declare Harmony here for future Harmony patches. You'll use Harmony to patch the game's code outside of the scope of the API.
        readonly Harmony harmony = new(PluginGuid);

        // These are variables that exist everywhere in the entire class.
        public const string PluginGuid = "creator.TheHexExpansionPart3";
        public const string PluginName = "The Hex Expansion Part 3";
        public const string PluginVersion = "1.1.0";
        public const string PluginPrefix = "THE_ALMIGHTY_HEXAGON";
        public int TribeCount = 0;

        public static Tribe CombatArenaX;
        public static Tribe RootbeerTender;
        public static Tribe SecretsOfLegendaria;
        public static Tribe SuperWeaselKid;
        public static Tribe TheWalk;
        public static Tribe ViciousGalaxy;
        public static Tribe WasteWorld;

        // Code for Everything:
        public void Awake()
        {
            THEHEXPACKPARTTHREE();
            // Tribe Creation
            CombatArenaX = TribeManager.Add(PluginGuid, "CombatArenaX", tribeIcon: TextureHelper.GetImageAsTexture("game_CAX.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("Rewardback_GAME_CAX.png"));
            TribeCount++;
            RootbeerTender = TribeManager.Add(PluginGuid, "RootbeerTender", tribeIcon: TextureHelper.GetImageAsTexture("game_RT.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("Rewardback_GAME_RT.png"));
            TribeCount++;
            SecretsOfLegendaria = TribeManager.Add(PluginGuid, "SecretsOfLegendaria", tribeIcon: TextureHelper.GetImageAsTexture("game_SOL.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("Rewardback_GAME_SOL.png"));
            TribeCount++;
            SuperWeaselKid = TribeManager.Add(PluginGuid, "SuperWeaselKid", tribeIcon: TextureHelper.GetImageAsTexture("game_SWK.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("Rewardback_GAME_SWK.png"));
            TribeCount++;
            TheWalk = TribeManager.Add(PluginGuid, "TheWalk", tribeIcon: TextureHelper.GetImageAsTexture("game_TW.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("Rewardback_GAME_TW.png"));
            TribeCount++;
            ViciousGalaxy = TribeManager.Add(PluginGuid, "ViciousGalaxy", tribeIcon: TextureHelper.GetImageAsTexture("game_VG.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("Rewardback_GAME_VG.png"));
            TribeCount++;
            WasteWorld = TribeManager.Add(PluginGuid, "WasteWorld", tribeIcon: TextureHelper.GetImageAsTexture("game_WW.png"), appearInTribeChoices: true, choiceCardbackTexture: TextureHelper.GetImageAsTexture("Rewardback_GAME_WW.png"));
            TribeCount++;
            Logger.LogInfo("Tribe count: " + TribeCount);

            // The_Hex_Packicon_Part_Three.png

            string cardCountString = CardsRegistration.Awake();
            int cardCount = int.Parse(cardCountString);
            Logger.LogInfo("Card count: " + cardCount);

        }

        public static void THEHEXPACKPARTTHREE()
        {
            if (Chainloader.PluginInfos.ContainsKey("zorro.inscryption.infiniscryption.packmanager"))
            {
                PackInfo TheHexPack = PackManager.GetPackInfo(TheHexExpansion.PluginPrefix);
                TheHexPack.Title = "The Hexagon";
                TheHexPack.SetTexture(TextureHelper.GetImageAsTexture("The_Hex_Packicon_Part_Three.png"));
                TheHexPack.Description = "THE ALMIGHTY HEXAGON SHALL RAIN DOWN UPON US ALL!!!!";
                TheHexPack.ValidFor.Add(PackInfo.PackMetacategory.LeshyPack);
                TheHexPack.ValidFor.Add(PackInfo.PackMetacategory.P03Pack);
            }
        }

        public class TheHexCardback : CardAppearanceBehaviour
        {
            public override void ApplyAppearance()
            {
                Texture2D ExampleBG = TextureHelper.GetImageAsTexture("The_Hex_Cardback.png");
                ExampleBG.filterMode = FilterMode.Point;
                base.Card.RenderInfo.baseTextureOverride = ExampleBG;
            }

            // When this card is chosen via a sequencer, run the following method. This example does nothing, but think *Ijaraq*.
            public override void OnCardAddedToDeck()
            {

            }

        }

        // Pass the appearance behaviour to the API by its Id.
        public readonly static CardAppearanceBehaviour.Appearance TheHexCardbackAppearence = CardAppearanceBehaviourManager.Add(PluginGuid, "TheHexPartThreeAppearence", typeof(TheHexCardback)).Id;
    }
}