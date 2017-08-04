using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace TutorialMod.Items.Armour
{
    // Added instread of AutoLoad
    [AutoloadEquip(EquipType.Body)]
    public class TutorialBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Breastplate"); // Set the name
            Tooltip.SetDefault("This is the Tutorial Breastplate\nThis is the second line."); // Set the tooltop
        }

        public override void SetDefaults()
        {
            /* Removed in 0.10
            item.name = "Tutorial Breastplate";
            item.toolTip = "This is the Tutorial Breastplate";
            */
            item.width = 18;
            item.height = 18;
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
