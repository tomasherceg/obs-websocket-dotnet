# OBS Remote Control

This is an experimental project that helps to control OBS from a web browser or from a different machine. It has a server-side service that allows to control OBS even on places where a direct connection is not available (corporate wi-fi networks). 

The communication with OBS is done via `obs-websocket` plugin, and uses [obs-websocket-dotnet](https://github.com/Palakis/obs-websocket-dotnet) for communication with it from C#.

Projects:

* ObsWebsocketDashboard - an ASP.NET Core web app that is deployed on server. It hosts a SignalR hub and contains a primitive dashboard that can be used to switch scenes and start/stop recording and streaming.

* ObsWebsocketProxy - a console app that is launched on a machine with OBS. It connects to the dashboard to allow remote control.

* ObsMouseTracker - a simple app that tracks mouse cursor position and switch scenes in OBS based on settings. I use it to hide a video from webcam when it covers the area of the screen I am workin with, and to restore the scene when I move the mouse elsewhere. The app also communicates with the dashboard.
# obs-websocket-dotnet
![Build status](https://github.com/Palakis/obs-websocket-dotnet/workflows/obs-websocket-dotnet%20Tests/badge.svg)  Releases: [![NuGet](https://img.shields.io/nuget/v/obs-websocket-dotnet.svg?style=flat)](https://www.nuget.org/packages/obs-websocket-dotnet)  

Official .NET library (written in C#) to communicate with an obs-websocket server.

This library is available on the [NuGet gallery](https://www.nuget.org/packages/obs-websocket-dotnet)  
See the `TestClient` project for a working example.  
  
# v5 Updates
NOTE: As OBS Websocket v5.0 is not backward compatible with 4.9.x, neither is the .Net version.  
**What's new in v5.0.0.3:**
* Fixed issue with integer overflow for OutputStatus objects  
(Older updates):
* Each event now has a dedicated EventArgs class. This will break the previous event signature
* Finished adding all v5 methods
* `Connect()` function is now obsolete, use `ConnectAsync()` instead.
* Additional bugfixes and stability fixes

Please report issues/bugs via the [Issues Tracker](https://github.com/BarRaider/obs-websocket-dotnet/issues) or discuss in our [Discord](http://discord.barraider.com)

This project is experimental. The way to install it and make it work is not polished, and includes manual compilation in Visual Studio, editing some configuration files, and deploying the dashboard to some server. I'll work on this when I have the concept tested, and maybe I'll run the dashboard for you.
## Dev Discussions
**Discord:** Discuss in #developers-chat in [Bar Raiders](http://discord.barraider.com)

Use it at your own risk.
## EOL for v4.x branch
NOTE: We will no longer be updating the v4.x branch as we move towards v5.0 (which is NOT backwards compatible).
