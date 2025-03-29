using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Goofy_Mod_Menu.Mods
{
    internal class UpAndDown
    {
        public static void UpAndDownMod()
        {
            if (ControllerInputPoller.instance.leftGrab)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += GorillaLocomotion.GTPlayer.Instance.headCollider.transform.up * Time.deltaTime * 3.5f;
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += GorillaLocomotion.GTPlayer.Instance.headCollider.transform.up * Time.deltaTime * -3.5f;
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
}
