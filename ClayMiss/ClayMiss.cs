using Terraria.ModLoader;

namespace ClayMiss
{
	class ClayMiss : Mod
	{
		public ClayMiss()
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
