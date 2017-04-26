using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Items.Accessories.Hooks
{
    public class TutorialHook : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.AmethystHook);
            item.name = "Tutorial Hook";
            item.shootSpeed = 18f;
            item.shoot = mod.ProjectileType("TutorialHook");
        }
    }
}
