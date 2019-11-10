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
    }
}
