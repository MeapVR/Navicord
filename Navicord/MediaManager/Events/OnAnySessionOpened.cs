
using System;
using WindowsMediaController;
using C = Navicord.ConsoleUtils;

namespace Navicord.WinMediaManager.Events
{
    internal class OnAnySessionOpened
    {
        internal protected static void Handle(MediaManager.MediaSession session)
        {
            C.Log("-- New Source: " + session.Id, ConsoleColor.Green);
        }
    }
}
