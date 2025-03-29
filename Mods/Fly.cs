using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using GorillaLocomotion;

namespace Goofy_Mod_Menu.Mods
{
    internal class Fly
    {
        public static void FlyMod()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += (GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;


            }
        }
    }
}