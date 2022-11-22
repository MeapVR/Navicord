using System;
using WindowsMediaController;
using C = Navicord.ConsoleUtils;

namespace Navicord.WinMediaManager.Events
{
    internal class OnFocusedSessionChanged
    {
        internal protected static void Handle(MediaManager.MediaSession mediaSession)
        {
            C.Log("== Session Focus Changed: " + mediaSession?.ControlSession?.SourceAppUserModelId, ConsoleColor.Gray);
        }
    }
}
