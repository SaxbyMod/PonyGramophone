using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using InscryptionAPI.Sound;

namespace ExampleMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]

    public class Plugin : BaseUnityPlugin
    {
        Harmony harmony = new Harmony(PluginGuid);

        private const string PluginGuid = "creator.pony.gramophone.add.tracks";
        private const string PluginName = "PonyGramaphoneMod";
        private const string PluginVersion = "1.0.0";

        //Initializes the configs
        public ConfigEntry<bool> configEnablePonyIsland;
        public ConfigEntry<bool> configEnableEnterPony;
        public ConfigEntry<bool> configEnableTheMachine;
        public ConfigEntry<bool> configEnableSanctuary;
        public ConfigEntry<bool> configEnableTheIsland;
        public ConfigEntry<bool> configEnableAdventureAwry;
        public ConfigEntry<bool> configEnableBeelzebub;
        public ConfigEntry<bool> configEnableLoueysPlayhouse;
        public ConfigEntry<bool> configEnableLoueysPlayhousePuzzleRemix;
        public ConfigEntry<bool> configEnableEscape;
        public ConfigEntry<bool> configEnableHopSkipAndANeigh;

        public void Awake()
        {
            // Summpms The Config file
            configEnablePonyIsland = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Pony Island?",
                                    true,
                                    "Should the 'Pony Island' Track Show up on the Gramophone?");
            configEnableEnterPony = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Enter Pony?",
                                    true,
                                    "Should the 'Enter Pony' Track Show up on the Gramophone?");
            configEnableTheMachine = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Machine?",
                                    true,
                                    "Should the 'The Machine' Track Show up on the Gramophone?");
            configEnableSanctuary = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Sanctuary?",
                                    true,
                                    "Should the 'Sanctuary' Track Show up on the Gramophone?");
            configEnableTheIsland = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Island?",
                                    true,
                                    "Should the 'The Island' Track Show up on the Gramophone?");
            configEnableAdventureAwry = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Adventure Awry?",
                                    true,
                                    "Should the 'Adventure Awry' Track Show up on the Gramophone?");
            configEnableBeelzebub = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Beelzebub?",
                                    true,
                                    "Should the 'Beelzebub' Track Show up on the Gramophone?");
            configEnableLoueysPlayhouse = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Loueys Playhouse?",
                                    true,
                                    "Should the 'Louey's Playhouse' Track Show up on the Gramophone?");
            configEnableLoueysPlayhousePuzzleRemix = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Loueys Playhouse Puzzle Remix?",
                                    true,
                                    "Should the 'Louey's Playhouse Puzzle Remix' Track Show up on the Gramophone?");
            configEnableEscape = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Escape?",
                                    true,
                                    "Should the 'Escape' Track Show up on the Gramophone?");
            configEnableHopSkipAndANeigh = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Hop Skip And A Neigh?",
                                    true,
                                    "Should the 'Hop Skip And A Neigh' Track Show up on the Gramophone?");
            //Music Num
            int MusicAmount = 0;

            // Apply our harmony patches.
            harmony.PatchAll(typeof(Plugin));

            //Summons the music
            if (configEnablePonyIsland.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_01.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableEnterPony.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_02.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTheMachine.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_03.mp3", 0.5f);
                MusicAmount++;
            }
            if (configEnableSanctuary.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_04.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTheIsland.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_05.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableAdventureAwry.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_06.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableBeelzebub.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_07.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableLoueysPlayhouse.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_08.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableLoueysPlayhousePuzzleRemix.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_09.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableEscape.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_10.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableHopSkipAndANeigh.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_11.mp3", 0.5f);

                MusicAmount++;
            }
            // Was this sucsessful?
            Logger.LogInfo($"Sucsessfully Loaded {MusicAmount} Song(s)");


        }
    }
}
