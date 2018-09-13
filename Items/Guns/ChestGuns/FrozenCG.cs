using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace ArsenalMod.Items.Guns.ChestGuns
{
    public class FrozenCG : JungleCG
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frozen chest gun");
			Tooltip.SetDefault("A gun made of chests shooting chests.");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LihzahrdChest, 2);
			recipe.AddIngredient(ItemID.FrozenChest);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}