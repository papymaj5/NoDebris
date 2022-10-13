using System;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace NoDebris
{
    [StaticConstructorOnStartup]
    public class HarmonyPatches
    {
        static HarmonyPatches()
        {
            new Harmony("Papymaj5.NoDebris").PatchAll(Assembly.GetExecutingAssembly());
        }

        [HarmonyPatch(typeof(SectionLayer_TerrainScatter), "Visible", 1)]
        internal static class HideTerrainScatter
        {
            [HarmonyPrefix]
            public static bool Patch_SectionLayer_TerrainScatter_Visible(ref bool __result)
            {
                __result = false;
                return false;
            }
        }
    }
}