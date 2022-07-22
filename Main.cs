using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using BepInEx;
using BepInEx.IL2CPP;

namespace RF5_MissionComplete
{
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInProcess(GAME_PROCESS)]
    public class Main : BasePlugin
    {
        #region PluginInfo
        private const string GUID = "27ACD694-6AF8-3FD3-BEC0-32D0FCA1F8BF";
        private const string NAME = "RF5_MissionComplete";
        private const string VERSION = "1.1";
        private const string GAME_PROCESS = "Rune Factory 5.exe";
        #endregion

        public override void Load()
        {
            new Harmony(GUID).PatchAll();
        }
    }
}
