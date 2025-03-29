using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Goofy_Mod_Menu.Mods
{
    internal class PBBVNameCycle
    {
        private static float nameCycleDelay; // Time until the next name cycle
        private static int nameCycleIndex;  // Index for cycling names

        public static void PBBVNameCycleMod()
        {
            if (Time.time > nameCycleDelay)
            {
                // Increment the index and loop back to 1 if it exceeds 3
                nameCycleIndex++;
                if (nameCycleIndex > 3)
                {
                    nameCycleIndex = 1;
                }

                // Change the name based on the index
                switch (nameCycleIndex)
                {
                    case 1:
                        ChangeName("PBBV");
                        break;
                    case 2:
                        ChangeName("IS");
                        break;
                    case 3:
                        ChangeName("HERE");
                        break;
                }

                // Update the delay for the next cycle
                nameCycleDelay = Time.time + 1f;
            }
        }

        // Method to change the name (replace with your implementation)
        private static void ChangeName(string newName)
        {
            Debug.Log($"Changing name to: {newName}");
            // Add the actual code for changing the name here
        }
    }
}