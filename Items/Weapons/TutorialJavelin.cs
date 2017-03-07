using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Items.Weapons
{
    public class TutorialJavelin : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Tutorial Javelin";
            item.thrown = true; // Set this to true if the weapon is throwable.
            item.maxStack = 999; // Makes it so the weapon stacks.
            item.damage = 50;
            item.knockBack = 6f;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 25;
            item.useTime = 25;
            item.width = 30;
            item.height = 30;
            item.consumable = true; // Makes it so one is taken from stack after use.
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.value = 5000;
            item.rare = 2;
            item.shootSpeed = 10f;
            item.shoot = mod.ProjectileType<Projectiles.TutorialJavelin>();
        }

    }
}
