using Terraria;
using Terraria.ModLoader;

namespace Memes {
    class Memes : Mod {
        public Memes() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void UpdateMusic(ref int music) {
             if (Main.myPlayer != -1 && !Main.gameMenu) {
                 if (Main.player[Main.myPlayer].active && (Main.LocalPlayer.FindBuffIndex(BuffType("DatBoiBuff")) != -1)) {
                    music = GetSoundSlot(SoundType.Music, "Sounds/DatBoiS");
                 }
                 if (Main.player[Main.myPlayer].active && (Main.LocalPlayer.ZoneSandstorm)) {
                    music = GetSoundSlot(SoundType.Music, "Sounds/Darude");
                 }
                if (Main.player[Main.myPlayer].active && (Main.LocalPlayer.ZoneSnow)) {
                    music = GetSoundSlot(SoundType.Music, "Sounds/Snowhalation");
                }
            }
        }
    }
}
