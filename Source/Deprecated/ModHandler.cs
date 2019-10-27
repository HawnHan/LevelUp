using UnityEngine;
using Verse;

namespace LevelUp
{
    public class ModHandler : Mod
    {
        public ModHandler(ModContentPack content) : base(content)
        {
            settings = GetSettings<Settings>();
        }

        public static Settings settings;

        public override string SettingsCategory() => "LevelUp";

        public override void DoSettingsWindowContents(Rect inRect)
        {
            base.DoSettingsWindowContents(inRect);
            Provider.Get<IModSettingsWindow>().Draw(inRect);
        }
    }
}