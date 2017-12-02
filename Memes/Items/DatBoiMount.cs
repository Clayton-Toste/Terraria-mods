using Terraria.ID;
using Terraria.ModLoader;

namespace Memes.Items
{
	public class DatBoiMount : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dat Boi's unicycle");
			Tooltip.SetDefault("Here comes Dat Boi!");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 9001;
			item.rare = 5;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/DatBoiS");
			item.autoReuse = true;
            item.noMelee = true;
            item.mountType = mod.MountType("DatBoiMount");
		}
	}
}
