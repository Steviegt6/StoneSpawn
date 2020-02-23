using Terraria;
using Terraria.ModLoader;
using Terraria.World.Generation;
using StoneSpawn.Content.Gems.Amber;
using System.Collections.Generic;
using Terraria.GameContent.Generation;
using static Terraria.ModLoader.ModContent;

namespace StoneSpawn
{
	public class StoneSpawnWorld : ModWorld
	{
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != 1)
			{
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Adding Amber", StoneSpawnAmber));
			}
			base.ModifyWorldGenTasks(tasks, ref totalWeight);
		}
		private void StoneSpawnAmber(GenerationProgress progress)
			{
				progress.Message = "Adding Amber";
				for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
				{
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), TileType<AmberOre>());
				}
			}
		public StoneSpawnWorld()
		{

		}
	}
}