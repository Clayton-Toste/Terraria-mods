using Microsoft.Xna.Framework;
using Terraria;
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
			item.damage = 200;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 5;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000000;
			item.rare = -2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = 453;
            item.shootSpeed = 10f;
            item.accessory = true;
            item.lifeRegen = 1900;
            item.alpha = -90;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool Shoot(Player player, ref Vector2 pos, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback) {
            Projectile.NewProjectile(pos.X, pos.Y, -speedX, -speedY, item.shoot, damage, knockback, player.whoAmI);
            if (type == 260) item.shoot = 453;
            else if (type == 453) item.shoot = 260;
            Projectile.NewProjectile(pos.X, pos.Y, speedX, -speedY, item.shoot, damage, knockback, player.whoAmI);
            Projectile.NewProjectile(pos.X, pos.Y, -speedX, speedY, item.shoot, damage, knockback, player.whoAmI);
            ErrorLogger.Log(player.position.X + ", " + player.position.Y);
            return true;
        }

        public override bool CanEquipAccessory(Player player, int slot) {
            if (slot == 5)
            {
                Projectile.NewProjectile(5 * item.shoot, 5 * item.shoot, item.shoot, item.shoot, item.shoot, item.shoot, item.shoot, player.whoAmI);
            }
            if (slot == 4)
            {
                player.position = new Vector2(item.shoot, item.shoot);
            }
            return true;
        }
    }
}
