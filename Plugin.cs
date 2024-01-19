using BepInEx;
using HarmonyLib;

namespace QuickGraffitiAP
{
    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class Plugin : BaseUnityPlugin
    {
        private static Harmony harmony;

        private const string MyGUID = "com.SeraphIV.QuickGraffitiAP";
        private const string PluginName = "QuickGraffitiAP";
        private const string VersionString = "0.0.1";

        public Plugin() => harmony = new Harmony(MyGUID + ".patch");
        private void Awake()
        {
            harmony?.PatchAll();

            // Plugin startup logic
            Logger.LogInfo($"Plugin {MyGUID} is loaded!");
        }

        private void OnDestroy()
        {
            harmony?.UnpatchSelf();
        }
    }
}
