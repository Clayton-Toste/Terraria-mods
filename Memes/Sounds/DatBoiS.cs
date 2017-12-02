using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;

namespace Memes.Sounds
{
    public class DatBoiS : ModSound
    {
        public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
        {
            soundInstance = sound.CreateInstance();
            soundInstance.Volume = volume * 1000f;
            soundInstance.Pan = pan;
            soundInstance.Pitch = -1.0f * pan * 2;
            return soundInstance;
        }
    }
}