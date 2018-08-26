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
				if(npc.type == NPCID.Zombie || npc.type == NPCID.BigRainZombie || npc.type == NPCID.SmallRainZombie || npc.type == NPCID.BigFemaleZombie || npc.type == NPCID.SmallFemaleZombie || npc.type == NPCID.BigTwiggyZombie || npc.type == NPCID.SmallTwiggyZombie || npc.type == NPCID.BigSwampZombie || npc.type == NPCID.SmallSwampZombie || npc.type == NPCID.BigSlimedZombie || npc.type == NPCID.SmallSlimedZombie || npc.type == NPCID.BigPincushionZombie || npc.type == NPCID.SmallPincushionZombie || npc.type == NPCID.BigBaldZombie || npc.type == NPCID.SmallBaldZombie || npc.type == NPCID.BigZombie || npc.type == NPCID.SmallZombie || npc.type == NPCID.BaldZombie || npc.type == NPCID.ZombieEskimo || npc.type == NPCID.PincushionZombie || npc.type == NPCID.SlimedZombie || npc.type == NPCID.SwampZombie || npc.type == NPCID.TwiggyZombie || npc.type == NPCID. || npc.type == NPCID.FemaleZombie || npc.type == NPCID.ZombieRaincoat || npc.type == NPCID.ZombieMushroom || npc.type == NPCID.ZombieMushroomHat || npc.type == NPCID.ZombieDoctor || npc.type == NPCID.ZombieSuperman || npc.type == NPCID.ZombiePixie || npc.type == NPCID.ZombieXmas || npc.type == NPCID.ZombieSweater || npc.type == NPCID.ZombieElf || npc.type == NPCID.ZombieElfBeard || npc.type == NPCID.ZombieElfGirl || npc.type == NPCID.ArmedZombie || npc.type == NPCID.ArmedZombieEskimo || npc.type == NPCID.ArmedZombiePincussion || npc.type == NPCID.ArmedZombieSlimed || npc.type == NPCID.ArmedZombieSwamp || npc.type == NPCID.ArmedZombieTwiggy || npc.type == NPCID.ArmedZombieCenx || npc.type == NPCID.BloodZombie)
	    		{
	    			if (Main.rand.NextFloat() < .0500f)
	       	    		Item.NewItem(npc.getRect(), mod.ItemType("PieceOfFlesh"), Main.rand.Next(2, 4));
	    		}
//------------------------------------------------------------------------------------------------------
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