using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace TutorialMod
{
    public class TutorialPlayer : ModPlayer
    {
        public override void SetupStartInventory(IList<Item> items)
        {
            items.Clear();

            Item item = new Item();
            item.SetDefaults(mod.ItemType("TutorialWood"));
            item.stack = 5;
            items.Add(item);
        }
    }
}
