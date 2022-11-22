using System;
using Windows.Media.Control;
using WindowsMediaController;
using C = Navicord.ConsoleUtils;

namespace Navicord.WinMediaManager.Events
{
    internal class OnAnyMediaPropertyChanged
    {
        internal protected static void Handle(MediaManager.MediaSession sender, GlobalSystemMediaTransportControlsSessionMediaProperties args)
        {
            string artistNameT = String.IsNullOrEmpty(args.Artist) ? "" : $"{args.Artist}";
            C.Log($"{sender.Id} is now playing {args.Title} by {artistNameT}", ConsoleColor.Cyan);

            if (sender.Id != Shared.ApplicationToListenTo)
                return;

            Shared.songName = args.Title;
            Shared.artistName = artistNameT;

            DiscordRPC.SetRichPresence();
        }
    }
}