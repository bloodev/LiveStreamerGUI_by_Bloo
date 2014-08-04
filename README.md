# What is LS GUI By Bloo?
LivestreamerGUI By Bloo is a small open source C#.Net project that lets you watch streams (from twitch.tv and similar) by using [livestreamer] (https://github.com/chrippa/livestreamer#livestreamer)
It also allows you to input a file name and record a stream to a file (located at your desktop) instead of watching the stream in a media player.

![Screenshot](http://i.imgur.com/Z1R6ihd.png)

You can download the exe from [here](https://github.com/bloodev/LiveStreamerGUI_by_Bloo/raw/master/LiveStreamerGUI%20by%20Bloo/bin/Debug/LS%20GUI%20-%20Bloo.exe)

Disclaimer:
-----
This program comes with no warranty what so ever. 
It's licensed under the Unlicense license, included in the repo.

Author's note:
-----
Yes, I know there are much better version than mine and that it can be done much better. 
You can find better versions [here](https://github.com/chrippa/livestreamer/wiki/Alternative%20interfaces)
I was in need of a fast and reliable way of watching/recording my favorite streams w/o the need of writing them down every time, hence why I've placed them in a drop down box.

Features:
-----
* Allows you to pick a stream from a drop down menu
* Allows you to watch a stream in your favorite media player
* Allows you to record a stream to your desktop
* Has a link to download livestreamer
* Has the option to open up the livestreamer config file
* Has an example config livestreamer file
* Shows which command will be executed

Future plans:
-----
- Working with Twitch's API so the user can authenticate and thus have all of the channels he follows shown in the drop down box.
- Integration with Twitch's chat system via irc.
- Redirecting/hiding the output of the command prompt to the execution file.
- A way to save a custom list in the drop down menu (favorite menu).
- Color indication, indicating that one of your favorite streamer is streaming right now (with their stream title included), using Twitch's API.
- Bug fixes

Requirements:
-----
- .NET Framework 2.0 [Required]
- VLC, Bsplayer, MPC-HC or any other media player
- Livestreamer (CMD) [Required]