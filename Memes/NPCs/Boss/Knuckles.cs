using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Memes.NPCs.Boss {
    [AutoloadBossHead]
    public class Knuckles : ModNPC {

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ugandan Knuckles");
        }

        public override void SetDefaults() {
            npc.aiStyle = 5;  //5 is the flying AI
            npc.lifeMax = 145000 * 5;   //boss life
            npc.damage = 150;  //boss damage
            npc.defense = 80;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 788;
            npc.height = (1885 - 4) / 3;
            animationType = NPCID.DemonEye;   //How the boss will behave
            npc.aiStyle = NPCID.CrimsonAxe;
            Main.npcFrameCount[npc.type] = 3;    //boss frame/animation 
            npc.value = Item.buyPrice(0, 40, 75, 45);
            npc.npcSlots = 1f;
            npc.boss = true;  
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.buffImmune[24] = true;
            music = MusicID.Boss2;
            npc.netAlways = true;
        }

        public override void BossLoot(ref string name, ref int potionType) {
            potionType = ItemID.LesserHealingPotion;   //boss drops
            // Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("YourSword"));
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale) {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);  //boss life scale in expertmode
            npc.damage = (int)(npc.damage * 0.6f);  //boss damage increase in expermode
        }
    }
}