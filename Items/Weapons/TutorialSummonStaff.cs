using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Items.Weapons
{
    public class TutorialSummonStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Summon Staff");
            Tooltip.SetDefault("Summons a Summon Spirit.");
        }

        public override void SetDefaults()
        {
            item.summon = true;         // This is true if this weapon summons something
            item.mana = 10;             // The amount of Mana used.

            item.damage = 100;
            item.width = 26;
            item.height = 26;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.noMelee = true; // This is not a melee weapon
            item.knockBack = 2;
            item.value = Item.buyPrice(0, 1, 0, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item44;

            item.shoot = mod.ProjectileType("TutorialSummonSpirit");
            item.shootSpeed = 10f;

            item.buffType = mod.BuffType("TutorialSummonSpiritBuff");
            item.buffTime = 3600;                                       // 60 Seconds
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            return player.altFunctionUse != 2;
        }

        public override bool UseItem(Player player)
        {
            if(player.altFunctionUse == 2)
            {
                player.MinionNPCTargetAim();
            }
            return base.UseItem(player);
        }
    }
}
