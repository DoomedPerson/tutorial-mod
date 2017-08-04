using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Items.Tools
{
    public class TutorialHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Hammer");
            Tooltip.SetDefault("This is a modded hammer.");
        }

        public override void SetDefaults()
        {
            item.damage = 13; // Base Damage of the Weapon
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            item.useTime = 16; // Speed before reuse
            item.useAnimation = 16; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.knockBack = 1f; // Weapon Knockbase: Higher means greater "launch" distance
            item.value = 5500; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false

            item.hammer = 70; // Hammer Power - Higher Value = Better
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "TutorialBar", 10);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
