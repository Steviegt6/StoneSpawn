using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn.Content.Gems.Topaz
{
    public class TopazProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Topaz");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            projectile.width = 18;
            projectile.height = 14;
            projectile.alpha = 0;
            projectile.timeLeft = 1200;
            projectile.penetrate = 1;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            aiType = ProjectileID.SnowBallFriendly;
        }
        public override void AI()
        {
            base.AI();
            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 20f)
            {
                projectile.velocity.Y = projectile.velocity.Y + 0.25f;
                projectile.velocity.X = projectile.velocity.X * 0.99f;
            }
            projectile.rotation += (Math.Abs(projectile.velocity.X) + Math.Abs(projectile.velocity.Y)) * 0.04f * (float)projectile.direction;
        }
        public override void Kill(int timeLeft)
        {
            base.Kill(timeLeft);
            Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Item10, projectile.position);
        }
    }
}
