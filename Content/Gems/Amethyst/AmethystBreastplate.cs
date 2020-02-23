using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn.Content.Gems.Amethyst
{
    [AutoloadEquip(EquipType.Body)]
    public class AmethystBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Amethyst Chainmail");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 18;
            item.height = 18;
            item.value = ((600 * 5) + ((375 * 5) * 25));
            item.defense = 3;
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Amethyst, 25);
            recipe.AddIngredient(ItemID.CopperChainmail, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
