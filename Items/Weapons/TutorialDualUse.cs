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
            if(player.altFunctionUse == 2) // Right Click function
            {
                item.useTime = 20;
                item.useAnimation = 20;
                // Right Click will shoot Snowballs
                item.shootSpeed = 16f; 
                item.shoot = ProjectileID.SnowBallFriendly;
            } else // Default Left Click
            {
                item.useTime = 10;
                item.useAnimation = 10;
                // Left Click has no projectile
                item.shootSpeed = 0f;
                item.shoot = 0;
            }
            return base.CanUseItem(player);
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if(player.altFunctionUse == 2) // If the Right click function 
            {
                target.AddBuff(BuffID.Frostburn, 60);
            } else // If Left Click Function 
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
