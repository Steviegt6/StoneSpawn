using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn.Content.Gems.Topaz
{
    [AutoloadEquip(EquipType.Head)]
    public class TopazHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Topaz Helmet");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            item.width = 18;
            item.height = 18;
            item.value = ((375 * 5) + ((750 * 5) * 15));
            item.defense = 3;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<TopazBreastplate>() && legs.type == ItemType<TopazLeggings>();
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
            recipe.AddIngredient(ItemID.Topaz, 15);
            recipe.AddIngredient(ItemID.TinHelmet, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
