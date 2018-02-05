using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Memes.Items {
    public class VRChat : ModItem {

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("VRChat");
            Tooltip.SetDefault("Welcome, player. If you encounter and annoying user...");
        }
        
        public override void SetDefaults() {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player) {           
            return !NPC.AnyNPCs(mod.NPCType("Knuckles"));  //you can't spawn this boss multiple times
            return !Main.dayTime;   //can use only at night
        }

        public override bool UseItem(Player player) {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Knuckles"));   //boss spawn
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);

            return true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
