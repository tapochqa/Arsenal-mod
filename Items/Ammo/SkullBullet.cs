using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArsenalMod.Items.Ammo
{
	public class SkullBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Skull Bullet");
		}

		public override void SetDefaults()
		{
			item.damage = 12;
			item.ranged = true;
			item.width = 42;
			item.height = 24;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("SkullBullet");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 1f;                  //The speed of the projectile
			item.ammo = item.type;              //The ammo class this ammo belongs to.
		}

		// Give each bullet consumed a 20% chance of granting the Wrath buff for 5 seconds
		//public override void OnConsumeAmmo(Player player)
		//{
		//	if (Main.rand.NextBool(5))
		//	{
		//		player.AddBuff(BuffID.Wrath, 300);
		//	}
		//}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 50);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}