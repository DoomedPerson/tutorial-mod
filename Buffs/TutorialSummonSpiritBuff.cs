using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace TutorialMod.Buffs
{
    public class TutorialSummonSpiritBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Summon Spirit");
            Description.SetDefault("A Summon Spirit that will fight for you!");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            TutorialPlayer tutorialPlayer = player.GetModPlayer<TutorialPlayer>(mod);
            if(player.ownedProjectileCounts[mod.ProjectileType("TutorialSummonSpirit")] > 0)
            {
                tutorialPlayer.summonSpiritMinion = true;
            }
            if(!tutorialPlayer.summonSpiritMinion)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            } else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}
