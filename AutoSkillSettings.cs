using System.Windows.Forms;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace AutoSkill
{
    public class AutoSkillSettings : ISettings
    {
        public AutoSkillSettings()
        {
            //plugin itself
            Enable = new ToggleNode(false);
            
            // ToggleKey = new ToggleNode(false);

            SkillKeyPressed = Keys.W;
            SkillSettings = new EmptyNode();
            CheckNearbyMonsters = new ToggleNode(false);
            UseBelowHpPercent = new ToggleNode(false);
            UseWhileGracePeriod = new ToggleNode(false);
            ThrottleFrequency = new ToggleNode(false);
            ConnectedSkill = new RangeNode<int>(1, 1, 8);
            NearbyMonster = new RangeNode<int>(5, 1, 100);
            NearbyMonsterRange = new RangeNode<int>(400, 1, 3000);
            HpPercentage = new RangeNode<int>(10, 0, 100);
            ExtraDelay = new RangeNode<int>(4000, 0, 10000);
        }

        //Menu
        [Menu("Skill Settings", 1)]
        public EmptyNode SkillSettings { get; set; }

        [Menu("Skill Hotkey", "Set the hotkey of the skill", 10, 1)]
        public HotkeyNode SkillKeyPressed { get; set; }

        [Menu("Connected Skill", "Set the skill slot (1 = top left, 8 = bottom right)", 11, 1)]
        public RangeNode<int> ConnectedSkill { get; set; }

        [Menu("Check Nearby Monsters", 2)]
        public ToggleNode CheckNearbyMonsters { get; set; }

        [Menu("Nearby Monster Range", 12, 2)]
        public RangeNode<int> NearbyMonsterRange { get; set; }

        [Menu("Nearby Monsters", 13, 2)]
        public RangeNode<int> NearbyMonster { get; set; }

        [Menu("HP and buffs settings", 3)]
        public EmptyNode _ { get; set; }

        [Menu("Use When HP Is Below %", 1, 3)]
        public ToggleNode UseBelowHpPercent { get; set; }

        [Menu("HP %", 2, 3)]
        public RangeNode<int> HpPercentage { get; set; }

        [Menu("Allow use while has Grace Period buff is active", 3, 3)]
        public ToggleNode UseWhileGracePeriod { get; set; }

        [Menu("Throttle Frequency", 5)]
        public ToggleNode ThrottleFrequency { get; set; }

        [Menu("Delay", 15, 5)]
        public RangeNode<int> ExtraDelay { get; set; }

        public ToggleNode Enable { get; set; }
    }
}
