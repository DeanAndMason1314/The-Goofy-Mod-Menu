using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Goofy_Mod_Menu.Mods
{
    internal class PeeMod
    {
        public static void GoBathroomMod()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                Vector3 startPos = GorillaTagger.Instance.bodyCollider.transform.position + new Vector3(0f, -0.15f, 0f);
                Vector3 charVel = GorillaTagger.Instance.bodyCollider.transform.forward * 8.33f;

                int proj = -675036877;
                int trail = -1;
                var col = new Color(1f, 1f, 0f);

                LaunchProjectile(proj, trail, startPos, charVel, col);
            }
        }
        //made by voidz.plan u little skids
        public static void LaunchProjectile(int projHash, int trailHash, Vector3 pos, Vector3 vel, Color col)
        {
            var projectile = ObjectPools.instance.Instantiate(projHash).GetComponent<SlingshotProjectile>();

            if (trailHash != -1)
            {
                var trail = ObjectPools.instance.Instantiate(trailHash).GetComponent<SlingshotProjectileTrail>();
                trail.AttachTrail(projectile.gameObject, false, false);
            }

            var counter = 0;
            projectile.Launch(pos, vel, NetworkSystem.Instance.LocalPlayer, false, false, counter++, 1, true, col);
        }
    }
}