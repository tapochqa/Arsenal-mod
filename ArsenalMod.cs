using Terraria.ModLoader;

namespace ArsenalMod
{
	class ArsenalMod : Mod
	{
		public ArsenalMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
