using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using ObsWebsocketDashboard.Configuration;
using ObsWebsocketDashboard.Hubs;
using ObsWebsocketDashboard.Security;
using ObsWebsocketDashboard.Services;

namespace ObsWebsocketDashboard
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();

            services.AddMvc();

            services.AddSingleton<ClientStatusRepository>();

            services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = TokenAuthenticationHandler.AuthenticationScheme;
                    options.DefaultChallengeScheme = TokenAuthenticationHandler.AuthenticationScheme;
                })
                .AddScheme<AppTokenOptions, TokenAuthenticationHandler>(TokenAuthenticationHandler.AuthenticationScheme, options =>
                {
                    configuration.GetSection("App").Bind(options);
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ObsHub>("/obs");
                endpoints.MapRazorPages();
            });

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(env.WebRootPath)
            });
        }
    }
}
