using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Principal;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ObsWebsocketDashboard.Configuration;

namespace ObsWebsocketDashboard.Security
{
    public class TokenAuthenticationHandler : AuthenticationHandler<AppTokenOptions>
    {

        public const string AuthenticationScheme = "TokenAuthentication";

        public TokenAuthenticationHandler(IOptionsMonitor<AppTokenOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var accessToken = GetAccessToken();
            if (Guid.TryParse(accessToken, out var token))
            {
                if (Options.Tokens.Any(t => t.Token == token))
                {
                    // success
                    var claims = new[]
                    {
                        new Claim(ClaimTypes.Name, accessToken)
                    };
                    var identity = new ClaimsIdentity(claims, AuthenticationScheme);
                    var principal = new GenericPrincipal(identity, null);
                    var ticket = new AuthenticationTicket(principal, AuthenticationScheme);
                    return Task.FromResult(AuthenticateResult.Success(ticket));
                }
                else
                {
                    return Task.FromResult(AuthenticateResult.Fail("Invalid token"));
                }
            }
            else
            {
                return Task.FromResult(AuthenticateResult.Fail("Token not found"));
            }
        }

        private string GetAccessToken()
        {
            var queryParam = Context.Request.Query["access_token"];
            if (!string.IsNullOrEmpty(queryParam))
            {
                return queryParam;
            }
            else
            {
                var header = Context.Request.Headers["Authorization"];
                if (!string.IsNullOrEmpty(header))
                {
                    var parsedHeader = AuthenticationHeaderValue.Parse(header);
                    if (string.Equals(parsedHeader.Scheme, "Bearer", StringComparison.CurrentCultureIgnoreCase))
                    {
                        return parsedHeader.Parameter;
                    }
                }
            }

            return null;
        }
    }
}