using System;
using Windows.Media.Control;
using WindowsMediaController;
using C = Navicord.ConsoleUtils;

namespace Navicord.WinMediaManager.Events
{
    internal class OnAnyPlaybackStateChanged
    {
        internal protected static void Handle(MediaManager.MediaSession sender, GlobalSystemMediaTransportControlsSessionPlaybackInfo args)
        {
            C.Log($"{sender.Id} is now {args.PlaybackStatus}", ConsoleColor.Yellow);

            if (sender.Id != Shared.ApplicationToListenTo)
                return;

            switch (args.PlaybackStatus.ToString())
            {
                case "Playing":
                    DiscordRPC.SetRichPresence();
                    break;

                case "Stopped":
                    DiscordRPC.ClearRichPresence();
                    break;

                case "Paused":
                    DiscordRPC.ClearRichPresence();
                    break;
            }
        }
    }
}
