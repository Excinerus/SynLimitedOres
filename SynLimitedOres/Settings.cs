using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutagen.Bethesda.Synthesis.Settings;

namespace SynLimitedOres
{
    public record Settings
    {
        [SynthesisOrder]
        [SynthesisSettingName("Sets ores in mines to respawn")]
        public bool RespawningMines = true;
        //[SynthesisSettingName("Only mines with an active workfroce will respawn")]
        //public bool OnlyActiveMinesRespawn = true;
        [SynthesisSettingName("Sets other underground ores (caves, crypts & dwemer ruins) to respawn")]
        public bool RespawningOtherUnderground = false;

    }
}
