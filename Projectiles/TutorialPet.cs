using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Projectiles
{
    public class TutorialPet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
            aiType = ProjectileID.ZephyrFish;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false; // Sets the default cloned pet to false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            TutorialPlayer modPlayer = player.GetModPlayer<TutorialPlayer>(mod);
            if(player.dead)
            {
                modPlayer.tutorialPet = false;
            }
            if(modPlayer.tutorialPet)
            {
                projectile.timeLeft = 2; // Remain at 2 while tutorialPet == true;
            }
        }
    }
}
