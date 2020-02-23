using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn.Content.Gems.Amethyst
{
    public class AmethystBroadsword : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Amethyst Broadsword");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.CloneDefaults(ItemID.CopperBroadsword);
            item.damage = 12;
            item.value = 15450;
            item.shoot = ProjectileType<AmethystProj>();
            item.shootSpeed = 8f;
            item.scale = 1.1f;
            item.useTime = 32;
            item.useAnimation = 32;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            return true;
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Amethyst, 8);
            recipe.AddIngredient(ItemID.CopperBroadsword, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}