using Terraria;
using Terraria.ModLoader;
 
namespace Memes.Buffs {
    public class DatBoiBuff : ModBuff {

        public override void SetDefaults() {
            DisplayName.SetDefault("Dat Boi Mount");
            Description.SetDefault("Oh, here comes Dat Boi!");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }
 
        public override void Update(Player player, ref int buffIndex) {
            player.mount.SetMount(mod.MountType("DatBoiMount"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}