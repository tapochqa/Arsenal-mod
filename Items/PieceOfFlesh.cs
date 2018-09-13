using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace ArsenalMod.Items
{
	public class PieceOfFlesh : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Piece Of Flesh");
			Tooltip.SetDefault("A piece of slayed zombie.");
		}
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 20;
            item.maxStack = 99;
			item.value = 10000;
			item.rare = 0;
		}
	}
}
