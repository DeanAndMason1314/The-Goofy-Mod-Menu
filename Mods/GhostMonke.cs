using System;
using System.Collections.Generic;
using System.Text;

namespace Goofy_Mod_Menu.Mods
{
    internal class GhostMonke
    {
        public static void GhostMonkeMod()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }

            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }

    }
}
