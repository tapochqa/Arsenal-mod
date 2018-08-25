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
	    	}
	    }
}