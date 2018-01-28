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

        // public Override void UpdateMusic(ref int music) {
        //     if (Main.myPlayer != -1 && !Main.gameMenu) {
        //         if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].GetModPlayer<MyPlayer>(this).ZoneCustomBiome) {
        //             // Yeah
        //         }
        //     }
        // }
    }
}
