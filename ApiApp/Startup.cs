using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = $"https://{Configuration["Auth0:Domain"]}/";
                options.Audience = Configuration["Auth0:ApiIdentifier"];
            });
            //services.AddAuthentication(options =>
            //    {
            //        options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //        options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //        options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    })
            //    .AddCookie()
            //    .AddOpenIdConnect("Auth0", options =>
            //    {
            //        options.Authority = $"https://{Configuration["Auth0:Domain"]}/";
            //        options.ClientId = Configuration["Auth0:ClientId"];
            //        options.ClientSecret = Configuration["Auth0:ClientSecret"];

            //        //Set response type to code
            //        options.ResponseType = "code";

            //        //configure the scope
            //        options.Scope.Clear();

            //        options.Scope.Add(("openid"));

            //        //Set the callback path
            //        options.CallbackPath = new PathString("/signin-auth0");

            //        //configure the Claims Issuer to be Auth0
            //        options.ClaimsIssuer = "Auth0";

            //        options.Events = new OpenIdConnectEvents
            //        {
            //            // handle the logout redirection
            //            OnRedirectToIdentityProviderForSignOut = (context) =>
            //            {
            //                var logoutUri =
            //                    $"https://{Configuration["Auth0:Domain"]}/v2/logout?client_id={Configuration["Auth0:ClientId"]}";

            //                var postLogoutUri = context.Properties.RedirectUri;
            //                if (!string.IsNullOrEmpty(postLogoutUri))
            //                {
            //                    if (postLogoutUri.StartsWith("/", StringComparison.CurrentCulture))
            //                    {
            //                        // transform to absolute
            //                        var request = context.Request;
            //                        postLogoutUri = request.Scheme + "://" + request.Host + request.PathBase +
            //                                        postLogoutUri;
            //                    }
            //                    logoutUri += $"&returnTo={Uri.EscapeDataString(postLogoutUri)}";
            //                }

            //                context.Response.Redirect(logoutUri);
            //                context.HandleResponse();

            //                return Task.CompletedTask;
            //            },
            //            OnRedirectToIdentityProvider = context =>
            //            {
            //                context.ProtocolMessage.SetParameter("audience", Configuration["Auth0:ApiIdentifier"]);
            //                return Task.FromResult(0);
            //            }
            //        };
            //    });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            //authentication
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}