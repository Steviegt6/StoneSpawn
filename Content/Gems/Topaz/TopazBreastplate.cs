using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn.Content.Gems.Topaz
{
    [AutoloadEquip(EquipType.Body)]
    public class TopazBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Topaz Chainmail");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 18;
            item.height = 18;
            item.value = ((50 * 5) + ((750 * 5) * 15));
            item.defense = 3;
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Topaz, 25);
            recipe.AddIngredient(ItemID.TinChainmail, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
