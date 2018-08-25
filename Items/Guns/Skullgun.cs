using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace ArsenalMod.Items.Guns
{
	public class Skullgun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Skullgun");
			Tooltip.SetDefault(" ");
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
			item.knockBack = 5;
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
			recipe.AddIngredient(ItemID.ObsidianSkull, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-15, 0);
		}
	}
}