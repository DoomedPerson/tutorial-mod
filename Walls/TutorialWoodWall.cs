using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;


namespace TutorialMod.Walls
{
    public class TutorialWoodWall : ModWall // ModWall is needed for all wall tiles
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true; // This wall can be used for a house;
            drop = mod.ItemType("TutorialWoodWall");
            AddMapEntry(new Color(110, 160, 190));
        }
    }
}
