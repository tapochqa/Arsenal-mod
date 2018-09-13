using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace ArsenalMod.Items
{
	public class NymphsHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nymph's head");
			Tooltip.SetDefault("Disgusting!");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 24;
			item.maxStack = 1;
			item.value = 10000;
			item.rare = 1;
		}
	}
}
