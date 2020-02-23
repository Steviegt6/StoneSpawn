using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn.Content.Gems.Amber
{
    public class AmberOre : ModTile
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Main.tileSolid[Type] = true;
            Main.tileShine[Type] = 900;
            Main.tileStone[Type] = true;
            drop = ItemID.Amber;
        }

    }
}