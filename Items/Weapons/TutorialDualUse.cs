using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace TutorialMod.Items.Weapons
{
    public class TutorialDualUse : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ugly Dagger");
            Tooltip.SetDefault("Does something if you Right Click.");
        }

        public override void SetDefaults()
        {
            item.melee = true;
            item.width = 26;
            item.height = 26;
            item.damage = 15;
            item.useTime = 10;
            item.useAnimation = 10;
            item.UseSound = SoundID.Item1;
            item.useStyle = 1;
            item.knockBack = 2f;
            item.value = 100;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = -1;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if(player.altFunctionUse == 2)
            {
                item.useTime = 20;
                item.useAnimation = 20;
                // Makes it so when you swing the weapon, you shoot a projectile.
                item.shootSpeed = 16f;
                item.shoot = ProjectileID.SnowBallFriendly;
            } else
            {
                item.useTime = 10;
                item.useAnimation = 10;
                item.damage = 2;
                item.shoot = 0; // Doesn't shoot a projectile
            }
            return base.CanUseItem(player);
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if(player.altFunctionUse == 2)
            {
                target.AddBuff(BuffID.Ichor, 60);
            } else
            {
                target.AddBuff(BuffID.OnFire, 60);
            }
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if(player.altFunctionUse == 2)
            {
                player.AddBuff(BuffID.Regeneration, 10);
            }
        }
    }
}
