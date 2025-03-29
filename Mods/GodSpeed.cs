using System;
using System.Collections.Generic;
using System.Text;

namespace Goofy_Mod_Menu.Mods
{
    internal class GodSpeed
    {
        public static void GodSpeedMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 200f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 300f;
        }
    }
}