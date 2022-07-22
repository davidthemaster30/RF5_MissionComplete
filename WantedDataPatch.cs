using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace RF5_MissionComplete
{
	[HarmonyPatch(typeof(RF5WANTED.WantedData), nameof(RF5WANTED.WantedData.CheckMonster))]
	public class WantedDataPatch
	{
		static bool Prefix(ref bool __result)
		{
			if (!RF5WANTED.WantedData.isAccepted)
				return true;

			__result = true;
			return false;
		}
	}
}
