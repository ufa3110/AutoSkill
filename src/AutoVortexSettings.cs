using System.Windows.Forms;
using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;

namespace AutoVortex
{
    public class AutoVortexSettings : SettingsBase
    {
        public AutoVortexSettings()
        {
            //plugin itself
            Enable = false;
            
            VortexKeyPressed = Keys.W;
            VortexConnectedSkill = new RangeNode<int>(1, 1, 8);
            NearbyMonster = new RangeNode<int>(5, 1, 100);
            NearbyMonsterRange = new RangeNode<int>(400, 1, 3000);
        }

        //Menu
        [Menu("Vortex Settings", 1)]
        public EmptyNode VortexSettings { get; set; }
        [Menu("Skill Hotkey", "Set the hotkey of the Vortex skill", 10, 1)]
        public HotkeyNode VortexKeyPressed { get; set; }
        [Menu("Connected Skill", "Set the skill slot (1 = top left, 8 = bottom right)", 11, 1)]
        public RangeNode<int> VortexConnectedSkill { get; set; }
        [Menu("Nearby Monsters", 12, 1)]
        public RangeNode<int> NearbyMonster { get; set; }
        [Menu("Nearby Monster Range", 13, 1)]
        public RangeNode<int> NearbyMonsterRange { get; set; }
    }
}
