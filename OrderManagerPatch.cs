using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace RF5_MissionComplete
{
	[HarmonyPatch(typeof(OrderManager), nameof(OrderManager.OrderFailureByOrderId))]
	public class OrderManagerPatch
	{
		static bool Prefix(int orderId, OrderManager __instance)
		{
			if (__instance.GetAcceptOrderData(orderId).IsComplete())
				return true;	// 已完成则取消任务
			else
				__instance.CompletedAllOrder(orderId);	// 未完成则完成它

			return false;
		}
	}
}
