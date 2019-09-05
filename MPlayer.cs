using Terraria.DataStructures;
using Terraria.ModLoader;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.GameContent;
using BSODOnDeath;

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