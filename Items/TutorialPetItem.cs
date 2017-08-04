using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Items
{
    public class TutorialPetItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blocky");
            Tooltip.SetDefault("Summons Block");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);  // Clone the defaults of Zephyr Fish
            item.shoot = mod.ProjectileType("TutorialPet");
            item.buffType = mod.BuffType("TutorialPetBuff");
        }

        public override void UseStyle(Player player)
        {
            if(player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "TutorialWood", 5);
            r.AddTile(null, "TutorialWorkbench");
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
