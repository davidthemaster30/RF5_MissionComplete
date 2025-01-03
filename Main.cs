using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace RF5_MissionComplete;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInProcess(GAME_PROCESS)]
public class Main : BasePlugin
{
    private const string GAME_PROCESS = "Rune Factory 5.exe";

    public override void Load()
    {
        new Harmony(MyPluginInfo.PLUGIN_GUID).PatchAll();
    }
}
