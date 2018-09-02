using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Chat;
using Terraria.ID;
using Terraria.GameContent.NetModules;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ArsenalMod.Projectiles
{
	public class ChestBullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chest bullet");     //The English name of the projectile
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;        //The recording mode
		}

		public override void SetDefaults()
		{
			projectile.width = 14;               //The width of projectile hitbox
			projectile.height = 16;              //The height of projectile hitbox
			projectile.aiStyle = -1;             //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			//projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = -1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
			//projectile.timeLeft = 600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			//projectile.alpha = 255;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)
			projectile.light = 0.5f;            //How much light emit around the projectile
			//projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
			//projectile.tileCollide = true;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
			//aiType = ProjectileID.Bullet;           //Act exactly like default Bullet
			//drawOffsetX = 5;
			//drawOriginOffsetY = 5;
		}

        public override void Kill(int timeLeft)
        {
            ChestBullet.aiKill(projectile, false, 0);
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            ChestBullet.OnHitCollide(projectile);
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            ChestBullet.OnHitCollide(projectile);
        }
        public override void OnHitPvp(Player target, int damage, bool crit)
        {
            ChestBullet.OnHitCollide(projectile);
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            ChestBullet.OnHitCollide(projectile, true); return false;
        }

        public const int explosionTimeLeft = 3;

         public static void OnHitCollide(Projectile projectile, bool tile = false)
        {
            if (tile) projectile.velocity = Vector2.Zero;
            projectile.timeLeft = explosionTimeLeft;
        }


    

		public override void AI()
		{
			projectile.ai[0] += 1f;
			if (projectile.ai[0] > 5f)
			{
				//projectile.ai[0] = 10f;
				// Roll speed dampening.
				if (projectile.velocity.Y == 0f && projectile.velocity.X != 0f)
				{
					projectile.velocity.X = projectile.velocity.X * 0.97f;
					//if (projectile.type == 29 || projectile.type == 470 || projectile.type == 637)
					{
						projectile.velocity.X = projectile.velocity.X * 0.99f;
					}
					if ((double)projectile.velocity.X > -0.01 && (double)projectile.velocity.X < 0.01)
					{
						projectile.velocity.X = 0f;
						//projectile.netUpdate = true;
					}
				}
				projectile.velocity.Y = projectile.velocity.Y + 0.2f;
			}
			// Rotation increased by velocity.X 
			projectile.rotation += projectile.velocity.X * 0.1f;
			ChestBullet.rocketAI(projectile, 90);
            return;
		}

         private static void aiExplode(Projectile projectile)
        {
            int explodeSize = 200;
            //projectile.damage = 100;
            if (projectile.timeLeft <= explosionTimeLeft)
            {
                if (projectile.aiStyle != 16) projectile.damage /= 2;
                projectile.aiStyle = 16; //explosion damage player

                projectile.tileCollide = false;
                projectile.ai[1] = 0f;
                projectile.alpha = 255;

                projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
                projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
                projectile.width = explodeSize;
                projectile.height = explodeSize;
                projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
                projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
                projectile.knockBack = 8f;
            }
        }

        private static void explosionFX(Projectile projectile)
        {
           
            
                projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
                projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
                projectile.width = 22;
                projectile.height = 22;
                projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
                projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
                int num9;
                for (int num616 = 0; num616 < 30; num616 = num9 + 1)
                {
                    int num617 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 31, 0f, 0f, 100, default(Color), 1.5f);
                    Dust dust = Main.dust[num617];
                    dust.velocity *= 1.4f;
                    num9 = num616;
                }
                for (int num618 = 0; num618 < 20; num618 = num9 + 1)
                {
                    int num619 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 6, 0f, 0f, 100, default(Color), 3.5f);
                    Main.dust[num619].noGravity = true;
                    Dust dust = Main.dust[num619];
                    dust.velocity *= 7f;
                    num619 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 6, 0f, 0f, 100, default(Color), 1.5f);
                    dust = Main.dust[num619];
                    dust.velocity *= 3f;
                    num9 = num618;
                }
                for (int num620 = 0; num620 < 2; num620 = num9 + 1)
                {
                    float scaleFactor9 = 0.4f;
                    if (num620 == 1)
                    {
                        scaleFactor9 = 0.8f;
                    }
                    int num621 = Gore.NewGore(new Vector2(projectile.position.X, projectile.position.Y), default(Vector2), Main.rand.Next(61, 64), 1f);
                    Gore gore = Main.gore[num621];
                    gore.velocity *= scaleFactor9;
                    Gore gore98 = Main.gore[num621];
                    gore98.velocity.X = gore98.velocity.X + 1f;
                    Gore gore99 = Main.gore[num621];
                    gore99.velocity.Y = gore99.velocity.Y + 1f;
                    num621 = Gore.NewGore(new Vector2(projectile.position.X, projectile.position.Y), default(Vector2), Main.rand.Next(61, 64), 1f);
                    gore = Main.gore[num621];
                    gore.velocity *= scaleFactor9;
                    Gore gore100 = Main.gore[num621];
                    gore100.velocity.X = gore100.velocity.X - 1f;
                    Gore gore101 = Main.gore[num621];
                    gore101.velocity.Y = gore101.velocity.Y + 1f;
                    num621 = Gore.NewGore(new Vector2(projectile.position.X, projectile.position.Y), default(Vector2), Main.rand.Next(61, 64), 1f);
                    gore = Main.gore[num621];
                    gore.velocity *= scaleFactor9;
                    Gore gore102 = Main.gore[num621];
                    gore102.velocity.X = gore102.velocity.X + 1f;
                    Gore gore103 = Main.gore[num621];
                    gore103.velocity.Y = gore103.velocity.Y - 1f;
                    num621 = Gore.NewGore(new Vector2(projectile.position.X, projectile.position.Y), default(Vector2), Main.rand.Next(61, 64), 1f);
                    gore = Main.gore[num621];
                    gore.velocity *= scaleFactor9;
                    Gore gore104 = Main.gore[num621];
                    gore104.velocity.X = gore104.velocity.X - 1f;
                    Gore gore105 = Main.gore[num621];
                    gore105.velocity.Y = gore105.velocity.Y - 1f;
                    num9 = num620;
                }
            
          
        }

        public static void aiKill(Projectile projectile, bool largeExplode = false, int tileExplode = 0)
        {
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 14);

            explosionFX(projectile);
        }

        public static void rocketAI(Projectile projectile, int dustType, bool largeExplode = false)
        {
            if (projectile.ai[0] == 3) Main.PlaySound(2, projectile.Center, 89);

            //aiDust(projectile, dustType);
            aiExplode(projectile);

        }
    
			//public override void Kill(int timeLeft) {}






		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			//Redraw the projectile with the color not influenced by light
			Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}
	}
}