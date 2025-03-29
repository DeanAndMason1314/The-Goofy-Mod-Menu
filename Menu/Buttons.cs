using Goofy_Mod_Menu.Mods;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static Goofy_Mod_Menu.Mods.Punch;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "SpeedBoost", method =() => SpeedBoost.SpeedBoostMod(), toolTip = "Makes you go fast. UND", isTogglable = true},
                new ButtonInfo { buttonText = "MosaSpeed", method =() => MosaSpeed.MosaSpeedMod(), toolTip = "Makes you go Like Mosa. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Platforms", method =() => Platforms.PlatformMod(), toolTip = "Press Buttion to have a lil platform. UND", isTogglable = true},
                new ButtonInfo { buttonText = "MakeDay", method =() => MakeDay.TimeDayMod(), toolTip = "LET THERE BE LIGHT!. UND", isTogglable = true},
                new ButtonInfo { buttonText = "GodSpeed", method =() => GodSpeed.GodSpeedMod(), toolTip = "WHATEVER YOU DO DONT TOUCH THE GROUND. UND", isTogglable = true},
                new ButtonInfo { buttonText = "GhostMonke", method =() => GhostMonke.GhostMonkeMod(), toolTip = "OUT OF BODY EXPERIENCE. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Fly", method =() => Fly.FlyMod(), toolTip = "Zoom Zoom. UND", isTogglable = true},
                new ButtonInfo { buttonText = "PBBVName", method =() => PBBVNameCycle.PBBVNameCycleMod(), toolTip = "Makes Ur Name like PBBV. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Punch", method =() => PunchModClass.PunchMod(), toolTip = "Punch, its self explanitory. UND", isTogglable = true},
                new ButtonInfo { buttonText = "BugOrbit", method =() => BugOrbit.BugOrbitMod(), toolTip = "THE BUG THINKS UR THE SUN. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Pee", method =() => PeeMod.GoBathroomMod(), toolTip = "Makes u pee everywhere. UND", isTogglable = true},
                new ButtonInfo { buttonText = "UpAndDown", method =() => UpAndDown.UpAndDownMod(), toolTip = "Makes u pee everywhere. UND", isTogglable = true},
                new ButtonInfo { buttonText = "BoxESP", method =() => BigBoxESP.BoxESPMod(), toolTip = "Makes u pee everywhere. UND", isTogglable = true}
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
