using DiscordRPC.Logging;
using DiscordRPC;
using C = Navicord.ConsoleUtils;

namespace Navicord
{
    internal class DiscordRPC
    {
        private protected static DiscordRpcClient client;

        internal protected static void InitializeRichPresence()
        {

            client = new DiscordRpcClient(Shared.DiscordDeveloperAppID);

            // Set the logger.
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            // Subscribe to events.
            client.OnReady += (sender, e) =>
            {
                C.Log($"Received reply from Discord: Ready from user {e.User.Username}");
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                C.Log($"Received reply from Discord, rich presence should be up to date.");
            };

            // Connect to the RPC.
            client.Initialize();
        }

        internal protected static void SetRichPresence()
        {
            client.SetPresence(new RichPresence()
            {
                Details = Shared.songName,
                State = "by " + Shared.artistName,

                Assets = new Assets()
                {
                    LargeImageKey = Shared.LargeImageKey,
                    SmallImageKey = Shared.SmallImageKey,
                    LargeImageText = Shared.LargeImageText,
                    SmallImageText = Shared.SmallImageText
                },

                Buttons = new Button[] // Please note that you can only have up to 2 buttons. I've set up two for you already. :)
                {
                    // Unfortunately searching for only song name doesn't work with Navidrome most of the time, so the first commented out button only really works in some cases, I could not think of a better way to do it.
                    //new Button() { Label = "Search song on Navidrome", Url = $"https://sound.meap.gg/app/#/album/all?displayedFilters=%7B%7D&filter=%7B%22name%22%3A%22" + Utilities.Encoding.UrlEncode($"{Shared.songName} {Shared.artistName}") + "%22%7D&order=ASC&page=1&perPage=18&sort=name" },
                    new Button() { Label = Shared.TextButton1, Url = Shared.StartOfURLButton1 + Utilities.UrlEncode($"{Shared.artistName} {Shared.songName}").Replace("+", "%20").ToLower()},
                    new Button() { Label = Shared.TextButton2, Url = Shared.StartOfURLButton2 + Utilities.UrlEncode($"{Shared.artistName} {Shared.songName}").Replace("+", "%20").ToLower()}
                },

                Timestamps = Timestamps.Now // Count from now (0 seconds) to the future (time elapsed until you switch to a new song or replay).

                // You can experiment with the below Timestamp stuff if you want. If you do then remove the 'Timestamps' from above.
                // I haven't found a way to figure out how long a song takes, if you do then you can implement it here.
                //    Timestamps = new DiscordRPC.Timestamps()
                //    {
                //        Start = DateTime.Now,
                //        End = DateTime.MaxValue
                //    }
            });
        }

        internal protected static void ClearRichPresence()
        {
            client.SetPresence(new RichPresence() { }); // Clears the rich presence so it doesn't show anymore on Discord.
        }
    }
}