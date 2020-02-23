using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn.Content.Gems.Amethyst
{
    [AutoloadEquip(EquipType.Legs)]
    public class AmethystLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Amethyst Greaves");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 18;
            item.height = 18;
            item.value = ((600 * 5) + ((375 * 5) * 20));
            item.defense = 2;
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Amethyst, 20);
            recipe.AddIngredient(ItemID.CopperGreaves, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
