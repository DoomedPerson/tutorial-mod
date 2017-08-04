using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Items.Weapons
{
    public class TutorialSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Spear");

        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.useStyle = 5;
            item.useAnimation = 18;
            item.useTime = 25;
            item.shootSpeed = 3.75f; // The shoot speed for the spear projectile.
            item.knockBack = 6.5f;
            item.width = 32;
            item.height = 32;
            item.scale = 1f; // The scale of the item.
            item.rare = 0;
            item.UseSound = SoundID.Item1;
            item.value = 1000;
            item.melee = true;
            item.autoReuse = true; // Will auto reuse the item.

            item.noMelee = true;
            item.noUseGraphic = true;
            item.shoot = mod.ProjectileType<Projectiles.TutorialSpear>();
        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < 1; // Only one spear can be on screen at a time. 
        }
    }
}
