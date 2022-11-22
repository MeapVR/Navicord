namespace Navicord
{
    internal class Shared
    {
        /*
         * Everything here is a default template for when the config.json file is first created.
         * You can adjust them without touching this code inside of the config.json file as these are just defaults.
         */

        /*
         * It is preferred to use a different browser/app and only use Navidrome in that browser/app.
         * If you do not do this and for example listen to music and watch a YouTube video at the same time in the same browser/app conflicts in rich presence will occur.
         * I for example personally use Microsoft Edge for only Navidrome because it lets you install Navidrome as an application to your taskbar and I use Firefox for everything else.
         * If you want to change it to another browser/app just enter the name of the .exe without the ".exe" at the end.
         */
        internal protected static string ApplicationToListenTo = "MSEdge"; // <-- Only listen to this browser/app (can be adjusted from config.json)

        /*
         * When enabled all console logging will be turned off and the application will start hidden.
         */
        internal protected static bool StartHidden = false;

        /*
         * The ID of your Discord Developer App if you decide to use your own.
         * Feel free to use the default or change it to your own in config.json.
         * https://discord.com/developers/applications
         */
        internal protected static string DiscordDeveloperAppID = "552897644872073230";

        /*
         * The small and large image that will show in the Discord rich presence.
         * If you are using your own Discord Developer App ID and you uploaded any images, you can put the filename (without extension) of that uploaded image here.
         * https://discord.com/developers/applications
         */
        internal protected static string LargeImageKey = "navidrome_icon";
        internal protected static string SmallImageKey = "navidrome_icon";

        /*
         * The text that will show when you hover your mouse over the large and small image in Discord.
         */
        internal protected static string LargeImageText = "Navidrome is awesome!";
        internal protected static string SmallImageText = "Navidrome is awesome!";

        /*
         * The text of the buttons that will show in Discord rich presence.
         */
        internal protected static string TextButton1 = "Search on Spotify";
        internal protected static string TextButton2 = "Search on YouTube Music";

        /*
         * The start of a URL before the song name and artist are added behind it as query.
         */
        internal protected static string StartOfURLButton1 = "https://open.spotify.com/search/";
        internal protected static string StartOfURLButton2 = "https://music.youtube.com/search?q=";

        /*
         * Stores the song name and artist name.
         * Not part of the config.json file.
         */
        internal protected static string songName;
        internal protected static string artistName;
    }

    internal class Settings
    {
        public bool StartHidden { get; set; }
        public string ApplicationToListenTo { get; set; }
        public string DiscordDeveloperAppID { get; set; }
        public string LargeImageKey { get; set; }
        public string SmallImageKey { get; set; }
        public string LargeImageText { get; set; }
        public string SmallImageText { get; set; }
        public string TextButton1 { get; set; }
        public string TextButton2 { get; set; }
        public string StartOfURLButton1 { get; set; }
        public string StartOfURLButton2 { get; set; }
    }
}