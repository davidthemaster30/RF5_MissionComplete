using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace RF5_MissionComplete
{
	[HarmonyPatch(typeof(Calc.CalcHandCuffs), nameof(Calc.CalcHandCuffs.LotteryWantedMonster))]
	public class CalcHandCuffsPatch
	{
		static bool Prefix(ref bool __result)
		{
			__result = true;
			return false;
		}
	}
}
