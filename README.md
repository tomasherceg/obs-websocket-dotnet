# OBS Remote Control

This is an experimental project that helps to control OBS from a web browser or from a different machine. It has a server-side service that allows to control OBS even on places where a direct connection is not available (corporate wi-fi networks). 

The communication with OBS is done via `obs-websocket` plugin, and uses [obs-websocket-dotnet](https://github.com/Palakis/obs-websocket-dotnet) for communication with it from C#.

Projects:

* ObsWebsocketDashboard - an ASP.NET Core web app that is deployed on server. It hosts a SignalR hub and contains a primitive dashboard that can be used to switch scenes and start/stop recording and streaming.

* ObsWebsocketProxy - a console app that is launched on a machine with OBS. It connects to the dashboard to allow remote control.

* ObsMouseTracker - a simple app that tracks mouse cursor position and switch scenes in OBS based on settings. I use it to hide a video from webcam when it covers the area of the screen I am workin with, and to restore the scene when I move the mouse elsewhere. The app also communicates with the dashboard.

This project is experimental. The way to install it and make it work is not polished, and includes manual compilation in Visual Studio, editing some configuration files, and deploying the dashboard to some server. I'll work on this when I have the concept tested, and maybe I'll run the dashboard for you.

Use it at your own risk.