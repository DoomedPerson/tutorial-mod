using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace TutorialMod.Items.Armour
{
    public class TutorialBreastplate : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Tutorial Breastplate";
            item.width = 18;
            item.height = 18;
            item.toolTip = "This is the Tutorial Breastplate";
            item.value = 1000;
            item.rare = 2;
            item.defense = 12; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("TutorialHelmet") && legs.type == mod.ItemType("TutorialLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Archery, 300);
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.statManaMax2 += 40;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "TutorialBar", 11);
            r.AddTile(TileID.Anvils); // Anvils = Iron, Lead, Mythril, etc
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
