using Terraria;
using Terraria.ModLoader;
 
namespace Memes.Buffs
{
    public class MountBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[this.Type] = "Dat Boi Mount";
            Main.buffTip[this.Type] = "Oh, here comes Dat Boi!";
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }
 
        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("DatBoiMount"), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}