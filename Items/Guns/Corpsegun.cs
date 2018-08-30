using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace ArsenalMod.Items.Guns
{
	public class Corpsegun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corpse gun");
			Tooltip.SetDefault("What it shoots?!");
		}
		public override void SetDefaults()
		{
			item.damage = 60;
			item.ranged = true;
			item.width = 70;
			item.height = 30;
			item.useTime = 60;
			item.useAnimation = 60;
			item.useStyle = 5;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item11;
			item.shoot = mod.ProjectileType("SkullBullet");
			item.shootSpeed = 1f;
			item.useAmmo = mod.ItemType("SkullBullet");
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
