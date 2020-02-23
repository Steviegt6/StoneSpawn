using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn.Content.Gems.Topaz
{
    public class TopazShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Topaz Shortsword");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.CloneDefaults(ItemID.TinShortsword);
            item.damage = 10;
            item.value = ((105 * 5) + ((750 * 5) * 7));
            item.shoot = ProjectileType<TopazProj>();
            item.shootSpeed = 8f;
            item.useTime = 28;
            item.useAnimation = 28;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if ((speedY > 0 && speedX > 0) || (speedY < 0 && speedX > 0))
            {
                speedX = 8;
            }
            else if ((speedY < 0 && speedX < 0) || (speedY > 0 && speedX < 0))
            {
                speedX = -8;
            }
            speedY = 0;
            return true;
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Topaz, 7);
            recipe.AddIngredient(ItemID.TinShortsword, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}