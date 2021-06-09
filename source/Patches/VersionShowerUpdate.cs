﻿using HarmonyLib;

namespace TownOfUs {

    [HarmonyPriority(Priority.VeryHigh)] // to show this message first, or be overrided if any plugins do
    [HarmonyPatch(typeof(VersionShower), nameof(VersionShower.Start))]
    public static class VersionShowerUpdate 
    {

        public static void Postfix(VersionShower __instance)
        {
            var text = __instance.text;
            //text.text += "\nloaded <color=#FFBFCCFF>T[FF80D5FF]o[FFCC00FF]w[704FA8FF]n[FF0000FF] of[CC4D00FF] Us [FFFFFFFF]by [00FF00FF]slushiegoose[FFFFFFFF] </color>;
            text.text +=
                $" - <color=#00FF00FF>TownOfUs v{TownOfUs.Version}</color>\n" +
                " Custom Town of Us patch by Sugden";
            text.transform.position = text.transform.position + new UnityEngine.Vector3(0f, -0.1f, 0f);
        }
    }
}
