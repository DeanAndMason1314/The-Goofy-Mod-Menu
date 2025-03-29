using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Goofy_Mod_Menu.Mods
{
    internal class Punch
    {
        public static class PunchModClass
        {
            public static void PunchMod()
            {
                float punchStrength = 5f;

                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    if (vrrig != GorillaTagger.Instance.offlineVRRig)
                    {
                        Vector3 rightHandPosition = GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.position;
                        Vector3 leftHandPosition = GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.position;
                        Vector3 playerPosition = GorillaTagger.Instance.bodyCollider.transform.position;
                        Rigidbody playerRigidbody = GorillaTagger.Instance.bodyCollider.attachedRigidbody;

                        if (Vector3.Distance(rightHandPosition, playerPosition) <= 0.52f)
                        {
                            playerRigidbody.velocity += (vrrig.rightHand.rigTarget.position - playerPosition).normalized * -punchStrength;
                        }

                        if (Vector3.Distance(leftHandPosition, playerPosition) <= 0.52f)
                        {
                            playerRigidbody.velocity += (vrrig.leftHand.rigTarget.position - playerPosition).normalized * -punchStrength;
                        }
                    }
                }
            }
        }

    }
}
