using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn.Content.Gems.Amethyst
{
    [AutoloadEquip(EquipType.Head)]
    public class AmethystHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Amethyst Helmet");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 18;
            item.height = 18;
            item.value = ((600 * 5) + ((375 * 5) * 15));
            item.defense = 2;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<AmethystBreastplate>() && legs.type == ItemType<AmethystLeggings>();
        }
        public override void UpdateArmorSet(Player player)
        {
            base.UpdateArmorSet(player);
            player.setBonus = "+3 defense";
            player.statDefense += 3;
        }
        public override void AddRecipes()
        {
            base.AddRecipes();
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Amethyst, 15);
            recipe.AddIngredient(ItemID.CopperHelmet, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
