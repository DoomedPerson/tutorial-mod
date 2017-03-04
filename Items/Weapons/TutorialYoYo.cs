using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Items.Weapons
{
    public class TutorialYoYo : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Tutorial YoYo";
            item.useStyle = 5; // The style used for YoYos.
            item.width = 24;
            item.height = 24;
            item.noUseGraphic = true; // Doesn't show Item in Hand.
            item.melee = true; // YoYos are a melee item.
            item.noMelee = true; // Don't damage enemies with the hand hitbox.
            item.channel = true; // ???
            item.UseSound = SoundID.Item1;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shoot = mod.ProjectileType<Projectiles.TutorialYoYo>(); // Projectile that is used with this weapon.
            item.shootSpeed = 16f; // How fast the projectile is shot.
            item.knockBack = 2.5f;
            item.damage = 9;
            item.value = 1000;
            item.rare = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "TutorialBar", 3);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
