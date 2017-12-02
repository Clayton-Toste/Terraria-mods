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
    }
}
