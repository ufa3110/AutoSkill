using System.Windows.Forms;
using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;

namespace AutoSkill
{
    public class AutoSkillSettings : SettingsBase
    {
        public AutoSkillSettings()
        {
            //plugin itself
            Enable = false;
            
            SkillKeyPressed = Keys.W;
            CheckNearbyMonsters = new ToggleNode(false);
            ConnectedSkill = new RangeNode<int>(1, 1, 8);
            NearbyMonster = new RangeNode<int>(5, 1, 100);
            NearbyMonsterRange = new RangeNode<int>(400, 1, 3000);
            Frequency = new RangeNode<int>(4000, 100, 4000);
        }

        //Menu
        [Menu("Skill Settings", 1)]
        public EmptyNode SkillSettings { get; set; }
        [Menu("Skill Hotkey", "Set the hotkey of the skill", 10, 1)]
        public HotkeyNode SkillKeyPressed { get; set; }
        [Menu("Connected Skill", "Set the skill slot (1 = top left, 8 = bottom right)", 11, 1)]
        public RangeNode<int> ConnectedSkill { get; set; }
        [Menu("Check Nearby Monsters", 12, 1)]
        public ToggleNode CheckNearbyMonsters { get; set; }
        [Menu("Nearby Monsters", 13, 1)]
        public RangeNode<int> NearbyMonster { get; set; }
        [Menu("Nearby Monster Range", 14, 1)]
        public RangeNode<int> NearbyMonsterRange { get; set; }
        [Menu("Frequency", 15, 1)]
        public RangeNode<int> Frequency { get; set; }
    }
}
