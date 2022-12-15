using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace ShareAcc
{
    [Label("$Mods.ShareAcc.Config.Label")]
    public class ShareAccConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        public static ShareAccConfig Instance => ModContent.GetInstance<ShareAccConfig>();

        private const string scopeKey = "$Mods.ShareAcc.Config.Scope.";

        [Header(scopeKey + "Header")]

        [Label(scopeKey + "TeammateOnly.Label")]
        [Tooltip(scopeKey + "TeammateOnly.Tooltip")]
        [DefaultValue(false)]
        public bool TeammateOnly;

        [Label(scopeKey + "InRangeOnly.Label")]
        [Tooltip(scopeKey + "InRangeOnly.Tooltip")]
        [DefaultValue(false)]
        public bool InRangeOnly;

        [Label(scopeKey + "Range.Label")]
        [Tooltip(scopeKey + "Range.Tooltip")]
        [DefaultValue(64)]
        public int Range;
    }
}
