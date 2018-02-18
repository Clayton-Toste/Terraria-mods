using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Chat;

namespace Memes.NPCs.Boss {
    [AutoloadBossHead]
    public class Knuckles : ModNPC {

        String state = "spinning";
        int counter = 0;
        Vector2 v;

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ugandan Knuckles");
        }

        public override void SetDefaults() {
            npc.aiStyle = -1;  //5 is the flying AI
            npc.lifeMax = 145000 * 5;   //boss life
            npc.damage = 150;  //boss damage
            npc.defense = 80;    //boss defense
            npc.knockBackResist = 0f;
            npc.width = 788;
            npc.height = (1885 - 4) / 3;
            Main.npcFrameCount[npc.type] = 3;    //boss frame/animation 
            npc.value = Item.buyPrice(0, 40, 75, 45);
            npc.npcSlots = 1f;
            npc.boss = true;  
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            UsesPartyHat();
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.buffImmune[24] = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Dounodawae");
            npc.netAlways = true;
        }

        public override void AI() {
            npc.TargetClosest();
            Player player = Main.player[npc.target];
            if (state == "spinning") {
                npc.velocity = Vector2.Zero;
                npc.rotation += .5f;
                if (npc.rotation > Math.PI) {
                    npc.rotation = (float)-Math.PI;
                }
                counter += 1;
                if (counter >= 1000 && Math.Round(npc.rotation) == Math.Round(npc.AngleTo(player.position))) {
                    Vector2 moveTo = player.Center;
                    Vector2 distance = moveTo - npc.Center;
                    Vector2 v = distance * 0.02f;
                    if (v.Length() > 10) {
                        v *= 10 / v.Length();
                    }
                    npc.velocity = v;
                    state = "charging";
                }
            }
            if (state == "charging") {
                counter -= 10;
                if (counter <= 0) {
                    Main.numStars = 130;
                    Main.startSnowMoon();
                    for (int i = 0; i < 130; i++)
                    {
                        Star.SpawnStars();
                    }
                    state = "spinning";
                }
            }
            //Main.NewText(counter + "oooo");
            //Main.NewText(Math.Round(npc.rotation) + "ff");
            //Main.NewText(Math.Round(npc.AngleTo(player.position)));
            //NetMessage.SendChatMessageToClient(NetworkText.FromLiteral("ayy"), Color.AliceBlue, player.whoAmI);
            //npc.rotation = npc.AngleTo(player.position);
        }

        public override void OnHitPlayer(Player target, int damage, bool crit) {
            base.OnHitPlayer(target, damage, crit);
            target.AddBuff(BuffID.Bleeding, damage, false);
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