using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Items
{
    public class GlobalItemModifier : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if(item.type == ItemID.CopperShortsword)
            {
                item.damage = 100;
            }

            if(item.type == ItemID.CopperPickaxe)
            {
                item.pick = 200;
                item.useTime = 5;
                item.useAnimation = 10;
            }
        }
    }
}
