using System;
using Microsoft.AspNetCore.Authentication;

namespace ObsWebsocketDashboard.Configuration
{
    public class AppTokenOptions : AuthenticationSchemeOptions
    {
        public AllowedToken[] Tokens { get; set; }

    }
}