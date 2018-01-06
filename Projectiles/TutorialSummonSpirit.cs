using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Projectiles
{
    public class TutorialSummonSpirit : MinionAI
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
            ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
            ProjectileID.Sets.Homing[projectile.type] = true;
            ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.netImportant = true;
            projectile.width = 24;
            projectile.height = 24;
            projectile.friendly = true;
            projectile.minion = true; // This is true if the Projectile is a minion
            projectile.minionSlots = 1; // How many minion slots are taken up. 
            projectile.penetrate = -1;
            projectile.timeLeft = 18000;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
        }

        public override void Behaviour()
        {
            
        }

        public override void CheckActive()
        {
            Player player = Main.player[projectile.owner];
            TutorialPlayer tutorialPlayer = player.GetModPlayer<TutorialPlayer>(mod);
            if(player.dead)
            {
                tutorialPlayer.summonSpiritMinion = false;
            }
            if(tutorialPlayer.summonSpiritMinion)
            {
                projectile.timeLeft = 2;
            }
        }

        
    }
}
