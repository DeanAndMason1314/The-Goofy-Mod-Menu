using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class MosaSpeed
    {
        public static void MosaSpeedMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 4f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 4f;
        }
    }
}