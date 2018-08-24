using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace ArsenalMod.Items.Guns
{
    public class Chestgun : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chestgun");
			Tooltip.SetDefault("Chestgun seriously???");
		}
        public override void SetDefaults()
		{
			item.damage = 40;
			item.ranged = true;
			item.width = 70;
			item.height = 30;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = 5;
			item.knockBack = 8;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item36;
			item.shoot = mod.ProjectileType("ChestBullet");
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
			item.autoReuse = false;
		}
    }
}