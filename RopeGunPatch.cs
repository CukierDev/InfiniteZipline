using System;
using HarmonyLib;
using Sons.Weapon;

namespace InfiniteZipline
{
    [HarmonyPatch(typeof(RopeGunController), "Initialize", 0)]
	internal class RopeGunPatch
	{
		private static void Postfix(RopeGunController __instance)
		{
			__instance._maxRopeLength = Config.MaxRopeLength.Value;
			__instance._maxFiringRange = Config.MaxFiringLength.Value;
		}
	}
}