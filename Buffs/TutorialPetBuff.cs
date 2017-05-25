using Terraria;
using Terraria.ModLoader;

namespace TutorialMod.Buffs
{
    public class TutorialPetBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[Type] = "Blocky";
            Main.buffTip[Type] = "\"A Happy Pixel that follows you around!\"";
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;                             // Sets the buff time to cover 24hours?
            player.GetModPlayer<TutorialPlayer>(mod).tutorialPet = true;    // Sets the pet to true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("TutorialPet")] <= 0; // Sets to true if count is less than or equal to 0
            if(petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("TutorialPet"), 0, 0f, player.whoAmI, 0f, 0f); 
            }
        }
    }
}
