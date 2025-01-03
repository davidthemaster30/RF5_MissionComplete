using HarmonyLib;

namespace RF5_MissionComplete;

[HarmonyPatch(typeof(RF5WANTED.WantedData), nameof(RF5WANTED.WantedData.CheckMonster))]
public class WantedDataPatch
{
	static bool Prefix(ref bool __result)
	{
		if (!RF5WANTED.WantedData.isAccepted || RF5WANTED.WantedData.isFinished || RF5WANTED.WantedData.Completed)
		{
			return true;
		}

		__result = true;
		return false;
	}
}
