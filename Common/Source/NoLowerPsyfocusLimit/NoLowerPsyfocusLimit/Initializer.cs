namespace NoLowerPsyfocusLimit {
    [Verse.StaticConstructorOnStartup]
    public static class Initializer {
        static Initializer() {
            HarmonyLib.Harmony harmony = new HarmonyLib.Harmony("NoLowerPsyfocusLimit");
            harmony.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
        }
    }
    [HarmonyLib.HarmonyPatch(typeof(RimWorld.Pawn_PsychicEntropyTracker))]
    [HarmonyLib.HarmonyPatch("PsyfocusBand", HarmonyLib.MethodType.Getter)]
    static class NoLowerPsycocusLimit_Patch {
        [HarmonyLib.HarmonyPrefix]
        public static bool PsyfocusBand_Prefix(ref int __result) {
            __result = RimWorld.Pawn_PsychicEntropyTracker.MaxAbilityLevelPerPsyfocusBand.Count - 1;
            return false;
        }
    }
}
