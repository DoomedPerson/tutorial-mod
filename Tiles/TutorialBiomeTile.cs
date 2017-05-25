using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TutorialMod.Tiles
{
    public class TutorialBiomeTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true; // Is the tile solid
            AddMapEntry(new Color(255, 255, 0));
            drop = mod.ItemType("TutorialBiomeBlock"); // What item drops after destorying the tile
        }
    }
}
