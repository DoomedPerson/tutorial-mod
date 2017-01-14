using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Items
{
	public class TutorialSword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Tutorial Sword"; // Name of the Item
			item.damage = 20; // Base Damage of the Weapon
			item.melee = true; // Weapon Class Type
			item.width = 40; // Hitbox Width
			item.height = 40; // Hitbox Height
			item.toolTip = "This is a modded sword."; // First Tool Tip
            item.toolTip2 = "This is a second toolTip."; // Second Tool Tip
			item.useTime = 20; // Speed before reuse
			item.useAnimation = 20; // Animation Speed
			item.useStyle = 1; // 1 = Broadsword 
			item.knockBack = 4.5f; // Weapon Knockbase: Higher means greater "launch" distance
			item.value = 5000; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
			item.rare = 2; // Item Tier
			item.UseSound = SoundID.Item1; // Sound effect of item on use 
			item.autoReuse = true; // Do you want to torture people with clicking? Set to false
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(ItemID.DirtBlock, 10); // Ingredient for crafing
            recipe.AddIngredient(ItemID.Wood, 5);
            //recipe.AddIngredient(null, "TutorialItem", 1);
            recipe.AddTile(TileID.WorkBenches); // Tile / Workstation
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
