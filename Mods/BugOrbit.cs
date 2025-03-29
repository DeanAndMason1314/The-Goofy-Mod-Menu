using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Goofy_Mod_Menu.Mods
{
    internal class BugOrbit
    {
        public static void BugOrbitMod()
        {

            GameObject bug = GameObject.Find("Floating Bug Holdable");
            GorillaTagger.Instance.offlineVRRig.enabled = true;
            {
                float num = 1.2f;
                float num2 = Time.time * num;
                float num3 = 15f;
                Vector3 vector = GorillaTagger.Instance.offlineVRRig.transform.position + new Vector3(0f, 0.8f, 0f);
                Vector3 vector2 = new Vector3(Mathf.Cos(num2), 0f, Mathf.Sin(num2)) * num3;
                Vector3 vector3 = vector + vector2 * Time.deltaTime * 5f;
                bug.transform.position = vector3;


            }
        }
    }
}