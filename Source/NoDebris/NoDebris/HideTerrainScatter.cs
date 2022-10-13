using HarmonyLib;
using Verse;

namespace NoDebris
{
    [HarmonyPatch(typeof(SectionLayer_TerrainScatter), "Visible", MethodType.Getter)]
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
