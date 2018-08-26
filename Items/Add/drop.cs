using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace ArsenalMod.Items.Add
{
    public class MyGlobalNPC : GlobalNPC
    	{
	    	public override void NPCLoot(NPC npc)
	    	{
	    		if(npc.type == NPCID.DiggerHead)
	    		{
	    			if (Main.rand.NextFloat() < .1212f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("Wormsket"));
	    		}
	    		if(npc.type == NPCID.GiantWormHead)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("Wormsket"));
	    		}
	    		if(npc.type == NPCID.Nymph)
	    		{
	    			if (Main.rand.NextFloat() < .5000f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("NymphsHead"));
	    		}
//Все виды ЗОМБИ------------------------------------------------------------------------
				if(npc.type == NPCID.Zombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.BigRainZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.SmallRainZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.BigFemaleZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.SmallFemaleZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.BigTwiggyZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.SmallTwiggyZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.BigSwampZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.SmallSwampZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.BigSlimedZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.SmallSlimedZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.BigPincushionZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.SmallPincushionZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.BigBaldZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.SmallBaldZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.BigZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.SmallZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.BaldZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombieEskimo)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.PincushionZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.SlimedZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.SwampZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.TwiggyZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.FemaleZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombieRaincoat)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombieMushroom)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombieMushroomHat)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombieDoctor)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombieSuperman)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombiePixie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombieXmas)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombieSweater)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombieElf)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombieElfBeard)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ZombieElfGirl)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ArmedZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ArmedZombieEskimo)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ArmedZombiePincussion)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ArmedZombieSlimed)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ArmedZombieSwamp)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ArmedZombieTwiggy)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.ArmedZombieCenx)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				if(npc.type == NPCID.BloodZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
				/* Пример
				if(npc.type == NPCID.)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType(""));
	    		}
				*/
	    	}
	    }
}