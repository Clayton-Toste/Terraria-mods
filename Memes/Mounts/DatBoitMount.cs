using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
 
namespace Memes.Mounts {
    public class DatBoiMount : ModMountData {

        public Random random = new Random();

        public override void SetDefaults() {
            mountData.spawnDust = Dust.lavaBubbles;
            mountData.buff = mod.BuffType("DatBoiBuff");
            mountData.heightBoost = 50;          //How much the player is boosted in the vertical axis when mounted.
            mountData.fallDamage = 0f;
            mountData.runSpeed = 29f;
            mountData.dashSpeed = 38f;
            mountData.flightTimeMax = 0;
            mountData.fatigueMax = 0;
            mountData.jumpHeight = 200;
            mountData.acceleration = 0.19f;
            mountData.jumpSpeed = 40f;
            mountData.blockExtraJumps = false;
            mountData.totalFrames = 1;            //mount frame/animation
            mountData.constantJump = true;
            int[] array = new int[mountData.totalFrames];
            for (int l = 0; l < array.Length; l++) {
                array[l] = 50;
            }
            mountData.playerYOffsets = array;   
            mountData.xOffset = 13;
            mountData.yOffset = 20;          //how high is the mount from the player
            mountData.bodyFrame = random.Next(0, 25);          //player frame when it's on the mount
            mountData.playerHeadOffset = 22;
            mountData.standingFrameCount = 1;
            mountData.standingFrameDelay = 12;
            mountData.standingFrameStart = 0;
            mountData.runningFrameCount = 1;
            mountData.runningFrameDelay = 12;
            mountData.runningFrameStart = 0;
            mountData.flyingFrameCount = 1;
            mountData.flyingFrameDelay = 0;
            mountData.flyingFrameStart = 0;
            mountData.inAirFrameCount = 1;
            mountData.inAirFrameDelay = 12;
            mountData.inAirFrameStart = 0;
            mountData.idleFrameCount = 1;
            mountData.idleFrameDelay = 12;
            mountData.idleFrameStart = 0;
            mountData.idleFrameLoop = true;
            mountData.swimFrameCount = mountData.inAirFrameCount;
            mountData.swimFrameDelay = mountData.inAirFrameDelay;
            mountData.swimFrameStart = mountData.inAirFrameStart;
            if (Main.netMode != 2) {
                mountData.textureWidth = mountData.frontTexture.Width + 20;
                mountData.textureHeight = mountData.frontTexture.Height;
            }
        }
 
        public override void UpdateEffects(Player player) {
            if (Math.Abs(player.velocity.X) > 4f) {
                Rectangle rect = player.getRect();
                mountData.bodyFrame = random.Next(0, (int)player.bodyFrameCounter);
                //Dust.NewDust(new Vector2(rect.X, rect.Y), rect.Width, rect.Height, mod.DustType(""));
                //if (Main.rand.Next(3) == 0) {
                    //Projectile.NewProjectile(player.position.X, player.position.Y, player.velocity.X/2, -2, Main.rand.Next(Terraria.ID.ProjectileID.DD2Win) + 1, 30, 0, player.whoAmI);
                //}
            }
        }
    }
}