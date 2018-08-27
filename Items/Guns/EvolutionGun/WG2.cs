using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace ArsenalMod.Items.Guns.EvolutionGun
{
	public class Woodgun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wood gun2");
			Tooltip.SetDefault("A piece of log turned into a gun.");
		}
		public override void SetDefaults()
		{
			item.damage = 1;
			item.ranged = true;
			item.width = 70;
			item.height = 30;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 5;
			item.knockBack = 0;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item11;
			item.shoot = 10; 
			item.shootSpeed = 1f;
			item.useAmmo = AmmoID.Bullet;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Woodgun"));
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-15, 0);
		}
	}
}
