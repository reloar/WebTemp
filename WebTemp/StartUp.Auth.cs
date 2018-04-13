using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTemp;

[assembly:OwinStartup(typeof(StartUp))]
namespace WebTemp
{
	public partial class StartUp
	{
        public static void ConfigureAuth(IAppBuilder app)
        {
            var option = new CookieAuthenticationOptions()
            {
                CookieName = "Redirecting",
                LoginPath = new PathString("/Auth/Login")
            };
            app.UseCookieAuthentication(option);
        }
    }
}
