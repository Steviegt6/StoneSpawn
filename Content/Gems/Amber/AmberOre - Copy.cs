/*using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using StoneSpawn;

namespace StoneSpawn.Content.Gems.Amber
{
    public class AmberGrapplingHook : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Amber Hook");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.noUseGraphic = true;
            item.damage = 0;
            item.knockBack = 7f;
            item.useStyle = 5;
            item.shootSpeed = 13f;
            item.shoot = ProjectileType<AmberHook>;
            item.useAnimation = 20;
            item.useTime = 20;
            item.rare = 2;
            item.noMelee = true;
            item.value = ((3000 * 5) * 15);
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Amber, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}*/