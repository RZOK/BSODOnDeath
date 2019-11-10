using Terraria.DataStructures;
using Terraria.ModLoader;

namespace BSODOnDeath
{
    public class MPlayer : ModPlayer
    {
        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            BSOD.Blue.Crash();
        }
        public override void OnEnterWorld(Player player)
        {
            Main.NewText("BSODOnDeath is enabled! Your computer will bluescreen whenever you die, if you do not want this I suggest leaving the world!");
        }
    }
}
