using Terraria.ModLoader;
using Terraria.ID;
namespace TutorialMod.Items.Placeable
{
    public class TutorialOre : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Tutorial Ore"; // Name of the Item
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.toolTip = "This is a modded ore."; // First Tool Tip
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("TutorialOreTile");
            item.maxStack = 999; // The maximum number you can have of this item.
        }
    }
}
