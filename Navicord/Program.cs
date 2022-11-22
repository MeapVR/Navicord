using System;
using System.Runtime.InteropServices;

namespace Navicord
{
    class Program
    {
        private protected static IntPtr handle = GetConsoleWindow();
        [DllImport("kernel32.dll")]
        private protected static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        private protected static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private protected const int SW_HIDE = 0;

        private protected static void Main()
        {
            Console.Title = "Navicord";

            // Read all settings from config.json file.
            Utilities.ReadSettingsFromJSON("config.json");

            // Hide the console window if the .exe is run with "-silent" as launch parameter or StartHidden is enabled in config.json.
            if (Environment.CommandLine.Contains("-silent") || Shared.StartHidden)
            {
                ShowWindow(handle, SW_HIDE);
                Shared.StartHidden = true;
            }

            DiscordRPC.InitializeRichPresence();
            WinMediaManager.Manager.Setup();
            Console.ReadLine();
        }
    }
}