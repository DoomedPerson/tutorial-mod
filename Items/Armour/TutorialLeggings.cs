using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace TutorialMod.Items.Armour
{
    public class TutorialLeggings : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Tutorial Leggings";
            item.width = 18;
            item.height = 18;
            item.toolTip = "This is the Tutorial Leggings";
            item.value = 1000;
            item.rare = 2;
            item.defense = 10; // The Defence value for this piece of armour.
        }
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("TutorialBreastplate") && head.type == mod.ItemType("TutorialHelmet");
        }
        

        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Archery, 300);
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "TutorialBar", 15);
            r.AddTile(TileID.Anvils); // Anvils = Iron, Lead, Mythril, etc
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
