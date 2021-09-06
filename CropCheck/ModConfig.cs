using StardewModdingAPI.Utilities;

namespace CropCheck
{
    class ModConfig
    {
        public KeybindList ToggleKey { get; set; } = KeybindList.Parse("N");
        public int FruitTreeAlertNumber  { get; set; } = 1;
        public bool AutoUnsave { get; set; } = false;
    }
}
