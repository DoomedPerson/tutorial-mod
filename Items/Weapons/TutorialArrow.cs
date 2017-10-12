using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Items.Weapons
{
    public class TutorialArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Arrow");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = 2;
            item.shoot = mod.ProjectileType("TutorialArrow");
            item.shootSpeed = 4f;
            item.ammo = AmmoID.Arrow; // To assign the ammo type.
        }
    }
}
