# Discord Rich Presence for Navidrome

Navicord is a application that adds the songs you are listening to as your Discord status using rich presence.
It does this by grabbing song information from Windows using [WindowsMediaController](https://github.com/DubyaDude/WindowsMediaController) and [discord-rpc-csharp](https://github.com/Lachee/discord-rpc-csharp), a C# port of DiscordRPC.

## Features
 
 - Highly customizable using config file (start hidden, etc..)
 - Has rich presence buttons that redirects a user to the song you are listening to on either Spotify or YouTube Music right out of the box.

## Installation

__DISCLAIMER: PLEASE READ CAREFULLY__

It is preferred to use a different browser/app and only use Navidrome in that browser/app.
If you do not do this and for example listen to music on Navidrome and watch a YouTube video at the same time in the same browser/app, conflicts in rich presence will occur.
I for example personally use Microsoft Edge for only Navidrome because it lets you install Navidrome as an application to your taskbar and I use Firefox for everything else.
If you want to change it to another browser/app just enter the name of the executable without the ".exe" at the end in the "config.json" file behind "ApplicationToListenTo".

 - __Step 1:__ Download the [latest release](https://github.com/MeapVR/Navicord/releases), run it and read the disclaimer and press ok, the application will then close.
 - __Step 2:__ Open the "config.json" file that was created and change the settings to suit your needs, read the disclaimer above as you will probably want to set "ApplicationToListenTo" to another process.
 - __Step 3:__ Run "Navicord.exe" again and let it run in the background and that's all there really is to it.

If you want the application to run at system startup then you can do so using Windows built in [Task Scheduler](https://www.windowscentral.com/how-create-automated-task-using-task-scheduler-windows-10)

## Detailed Config Descriptions

 - __StartHidden__: When enabled all console logging will be turned off and the application will start hidden.
 - __ApplicationToListenTo__: See disclaimer above.
 - __DiscordDeveloperAppID__: The ID of your Discord Developer App if you decide to use your own.
 - __LargeImageKey__ & __SmallImageKey__: The small and large image that will show in the Discord rich presence. If you are using your own Discord Developer App ID and you uploaded any images, you can put the filename (without extension) of that uploaded image here.
 - __LargeImageText__ & __SmallImageText__: The text that will show when you hover your mouse over the large and small image in Discord.
 - __TextButton1__ & __TextButton2__: The text of the buttons that will show in Discord rich presence.
 - __StartOfURLButton1__ & __StartOfURLButton2__: The start of a URL before the song name and artist are added behind it as query.

## Feedback

__Any feedback is welcome!__ If you need/want a new feature, find a bug or think of any way to improve Navicord, 
please file a [GitHub issue](https://github.com/MeapVR/Navicord/issues) or ping Meap#6124 in Navidrome's [Discord Server](https://discord.gg/xh7j7yF).

## Documentation
Here are some useful direct links:

- [Discord Developer Portal](https://discord.com/developers/applications)

## Screenshots

<p align="left">
    <img width="215" height="66" src="https://cdn.discordapp.com/attachments/821517441595211808/1044691265754771598/image.png">
	<img width="466" height="455" src="https://cdn.discordapp.com/attachments/821517441595211808/1044690998300790835/image.png">
</p>