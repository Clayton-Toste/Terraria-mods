using Terraria.ID;
using Terraria.ModLoader;

namespace StarterMod.Items.TheShrug
{
	public class TheShrug : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The ¯\\_(ツ)_/¯");
			Tooltip.SetDefault("This is a very average sword ¯\\_(ツ)_/¯");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 1;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000000;
			item.rare = -2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = 51;
            item.shootSpeed = 50f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
