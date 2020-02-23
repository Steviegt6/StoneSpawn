using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn.Content.SetBonusAccessories
{
    public class Miner : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Miner Bonus");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.accessory = true;
            item.rare = 1;
            item.value = 100000 * 5;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
            player.pickSpeed -= 0.3f;
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MiningHelmet, 1);
            recipe.AddIngredient(ItemID.MiningShirt, 1);
            recipe.AddIngredient(ItemID.MiningPants, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}