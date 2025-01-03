using HarmonyLib;

namespace RF5_MissionComplete;

[HarmonyPatch(typeof(OrderManager), nameof(OrderManager.OrderFailureByOrderId))]
public class OrderManagerPatch
{
	static bool Prefix(int orderId, OrderManager __instance)
	{
		if (__instance.GetAcceptOrderData(orderId).IsComplete())
		{
			return true;
		}
		else
		{
			__instance.CompletedAllOrder(orderId);
		}

		return false;
	}
}
