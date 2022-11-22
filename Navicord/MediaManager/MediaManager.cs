using WindowsMediaController;

namespace Navicord.WinMediaManager
{
    internal class Manager
    {
        private protected static MediaManager mediaManager;
        internal protected static void Setup()
        {
            mediaManager = new MediaManager();

            mediaManager.OnAnySessionOpened += Events.OnAnySessionOpened.Handle;
            mediaManager.OnAnySessionClosed += Events.OnAnySessionClosed.Handle;
            mediaManager.OnFocusedSessionChanged += Events.OnFocusedSessionChanged.Handle;
            mediaManager.OnAnyPlaybackStateChanged += Events.OnAnyPlaybackStateChanged.Handle;
            mediaManager.OnAnyMediaPropertyChanged += Events.OnAnyMediaPropertyChanged.Handle;

            mediaManager.Start();
        }
    }
}