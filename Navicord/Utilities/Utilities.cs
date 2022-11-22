using System.IO;
using System.Web;
using System.Text.Json;
using C = Navicord.ConsoleUtils;
using System.Windows.Forms;
using System;

namespace Navicord
{
    internal class Utilities
    {
        internal protected static string UrlEncode(string str)
        {
            return HttpUtility.UrlEncode(str);
        }

        internal protected static void CreateDefaultJSONFile(string path)
        {
            Settings settings = new Settings();

            settings.StartHidden = Shared.StartHidden;
            settings.ApplicationToListenTo = Shared.ApplicationToListenTo;
            settings.DiscordDeveloperAppID = Shared.DiscordDeveloperAppID;
            settings.LargeImageKey = Shared.LargeImageKey;
            settings.SmallImageKey = Shared.SmallImageKey;
            settings.LargeImageText = Shared.LargeImageText;
            settings.SmallImageText = Shared.SmallImageText;
            settings.TextButton1 = Shared.TextButton1;
            settings.TextButton2 = Shared.TextButton2;
            settings.StartOfURLButton1 = Shared.StartOfURLButton1;
            settings.StartOfURLButton2 = Shared.StartOfURLButton2;

            File.WriteAllText(path, JsonSerializer.Serialize(settings, new JsonSerializerOptions() { WriteIndented = true }));
            C.Log("A new settings file named \"config.json\" has been created.");
            MessageBox.Show("A new settings file named \"config.json\" has been created!\n\nDISCLAIMER: PLEASE READ CAREFULLY!\n\nIt is preferred to use a different browser/app and only use Navidrome in that browser/app.\r\nIf you do not do this and for example listen to music on Navidrome and watch a YouTube video at the same time in the same browser/app, conflicts in rich presence will occur.\r\nI for example personally use Microsoft Edge for only Navidrome because it lets you install Navidrome as an application to your taskbar and I use Firefox for everything else.\r\nIf you want to change it to another browser/app just enter the name of the executable without the \".exe\" at the end in the \"config.json\" file behind \"ApplicationToListenTo\".\n\nFor more detailed descriptions of all the options in the config.json file, please check the github repository page.", "Please read before using");
            Environment.Exit(0);
        }

        internal protected static void ReadSettingsFromJSON(string path)
        {
            if (!File.Exists(path))
                CreateDefaultJSONFile(path);

            Settings settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText(path));

            Shared.StartHidden = settings.StartHidden;
            Shared.ApplicationToListenTo = settings.ApplicationToListenTo;
            Shared.DiscordDeveloperAppID = settings.DiscordDeveloperAppID;
            Shared.LargeImageKey = settings.LargeImageKey;
            Shared.SmallImageKey = settings.SmallImageKey;
            Shared.LargeImageText= settings.LargeImageText;
            Shared.SmallImageText = settings.SmallImageText;
            Shared.TextButton1 = settings.TextButton1;
            Shared.TextButton2 = settings.TextButton2;
            Shared.StartOfURLButton1 = settings.StartOfURLButton1;
            Shared.StartOfURLButton2 = settings.StartOfURLButton2;

            C.Log("Successfully applied settings from \"config.json\" file.");
        }
    }
}