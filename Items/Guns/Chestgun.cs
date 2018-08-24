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
			item.shoot = 10; 
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
			item.autoReuse = false;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 2 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(2));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 0);
		}
    }
}