/*using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn.Content.Gems.Amber
{
    public class AmberHook : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Amber Hook");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            projectile.width = 18;
            projectile.height = 18;
            projectile.alpha = 0;
            projectile.penetrate = 1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.timeLeft *= 10;
            projectile.aiStyle = 7;
        }
        public override void AI()
        {
            base.AI();

        }
        public override void Kill(int timeLeft)
        {
            base.Kill(timeLeft);
            Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Item10, projectile.position);
        }
    }
}
*/