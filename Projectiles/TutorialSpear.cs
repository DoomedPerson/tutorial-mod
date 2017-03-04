using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TutorialMod.Projectiles
{
    public class TutorialSpear : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.name = "Projectile Tutorial Spear";
            projectile.width = 18;
            projectile.height = 18;
            projectile.aiStyle = 19; // Spears use this AI Style.
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false; // Does the projectile stop if it has collided with a tile?
            projectile.scale = 1.3f; // The scale of the projectile
            projectile.hide = true; // Hides the projectile?
            projectile.ownerHitCheck = true;
            projectile.melee = true;
            projectile.alpha = 0; // The alpha value of the projectile
        }

        public float movementFactor
        {
            get { return projectile.ai[0]; }
            set { projectile.ai[0] = value; }
        }

        public override void AI()
        {
            Player projOwner = Main.player[projectile.owner];
            Vector2 ownerMountedCenter = projOwner.RotatedRelativePoint(projOwner.MountedCenter, true);

            projectile.direction = projOwner.direction;
            projOwner.heldProj = projectile.whoAmI;
            projOwner.itemTime = projOwner.itemAnimation;
            projectile.position.X = ownerMountedCenter.X - (float)(projectile.width / 2);
            projectile.position.Y = ownerMountedCenter.Y - (float)(projectile.height / 2);

            if(!projOwner.frozen)
            {
                if (movementFactor == 0f)
                {
                    movementFactor = 3f;
                    projectile.netUpdate = true;
                }
                if(projOwner.itemAnimation < projOwner.itemAnimationMax / 3)
                {
                    movementFactor -= 2.4f;
                } else
                {
                    movementFactor += 2.4f;
                }
            }

            projectile.position += projectile.velocity * movementFactor;

            if(projOwner.itemAnimation == 0)
            {
                projectile.Kill();
            }
        }
    }
}
