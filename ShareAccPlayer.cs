using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Default;

namespace ShareAcc
{
    public class ShareAccPlayer : ModPlayer
    {
        public override void UpdateEquips()
        {
            bool checkTeam = ShareAccConfig.Instance.TeammateOnly;
            bool checkRange = ShareAccConfig.Instance.InRangeOnly;
            int range = ShareAccConfig.Instance.Range;

            foreach (Player player in Main.player)
            {
                if (player != null && player.active && !player.dead && player.whoAmI != Player.whoAmI && (!checkTeam || player.team == Player.team) && (!checkRange || player.Center.DistanceSQ(Player.Center) <= Math.Pow(range * 16, 2)))
                {
                    foreach (Item acc in player.armor[3..])
                    {
                        if (acc != null && !acc.IsAir)
                        {
                            Player.ApplyEquipFunctional(acc, false);
                        }
                    }
                }
            }
        }
    }
}
