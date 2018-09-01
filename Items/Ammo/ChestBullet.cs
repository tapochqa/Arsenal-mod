using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArsenalMod.Items.Ammo
{
	public class ChestBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Chest bullet");
			Tooltip.SetDefault("Always wanted to shoot chests.");
		}

		public override void SetDefaults()
		{
			item.damage = 0;
			item.ranged = true;
			item.width = 14;
			item.height = 16;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 7;
			item.shoot = mod.ProjectileType("ChestBullet");
			item.shootSpeed = 10f;
			item.ammo = item.type;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 50);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}