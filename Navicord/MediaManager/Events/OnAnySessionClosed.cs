using System;
using WindowsMediaController;
using C = Navicord.ConsoleUtils;

namespace Navicord.WinMediaManager.Events
{
    internal class OnAnySessionClosed
    {
        internal protected static void Handle(MediaManager.MediaSession session)
        {
            C.Log("-- Removed Source: " + session.Id, ConsoleColor.Red);
        }
    }
}