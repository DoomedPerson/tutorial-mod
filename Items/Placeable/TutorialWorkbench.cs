using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Items.Placeable
{
    public class TutorialWorkbench : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Tutorial Workbench";
            item.width = 12;
            item.height = 12;
            item.useTime = 14;
            item.useAnimation = 17;
            item.useTurn = true;
            item.autoReuse = true;
            item.useStyle = 1;
            item.createTile = mod.TileType("TutorialWorkbench");
            item.consumable = true;
        }
    }
}
