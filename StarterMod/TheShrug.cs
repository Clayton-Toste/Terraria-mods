using Terraria.ModLoader;

namespace StarterMod
{
	class StarterMod : Mod
	{
		public StarterMod()
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
