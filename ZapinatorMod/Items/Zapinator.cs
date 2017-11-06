using Terraria.ID;
using Terraria.ModLoader;

namespace ZapinatorMod.Items
{
	public class Zapinator : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 50;
			item.magic = true;
			item.mana = 4;
			item.width = 10;
			item.height = 10;
			item.useTime = 7;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item12;
			item.autoReuse = true;
			item.shoot = 20;
			item.shootSpeed = 16f;
		}

		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SolarTablet, 1);
			recipe.AddIngredient(ItemID.SpaceGun, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
	}
}
