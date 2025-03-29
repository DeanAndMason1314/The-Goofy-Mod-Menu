using System;
using System.Collections.Generic;
using System.Text;

namespace Goofy_Mod_Menu.Mods
{
    internal class MakeDay
    {
        public static void TimeDayMod()
        {
            BetterDayNightManager.instance.SetTimeOfDay(5);
        }

    }
}