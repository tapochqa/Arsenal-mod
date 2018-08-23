using Terraria.ModLoader;

namespace SimpleMod
{
	class SimpleMod : Mod
	{
		public SimpleMod()
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
