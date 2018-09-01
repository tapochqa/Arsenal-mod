using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace ArsenalMod.Items.Guns.ChestGuns
{
    public class JungleCG : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jungle chest gun");
			Tooltip.SetDefault("Chestgun seriously???");
		}
        public override void SetDefaults()
		{
			item.damage = 0;
			item.ranged = true;
			item.width = 70;
			item.height = 30;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = 5;
			item.knockBack = 8;
			item.value = 10000;
			item.rare = 7;
			item.UseSound = SoundID.Item36;
			item.shoot = mod.ProjectileType("ChestBullet");
			//item.shootSpeed = 2f;
			item.useAmmo = mod.ItemType("ChestBullet");
			item.autoReuse = false;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LihzahrdChest, 2);
			recipe.AddIngredient(ItemID.JungleChest);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 0);
		}
    }
}