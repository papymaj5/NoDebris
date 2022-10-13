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
            Log.Message("Static Patches Class Loaded");
            Harmony harmony = new Harmony("Papymaj5.NoDebris");
            harmony.PatchAll();
        }
    }
}
