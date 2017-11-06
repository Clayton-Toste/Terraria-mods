using Terraria.ModLoader;

namespace ZapinatorMod
{
	class ZapinatorMod : Mod
	{
		public ZapinatorMod()
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
