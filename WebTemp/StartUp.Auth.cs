using Microsoft.AspNet.Identity;
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
				AuthenticationType ="AppCookie",
				LoginPath = new PathString("/Auth/Login")
			};
			app.UseCookieAuthentication(option);
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //   consumerKey: "",
            //   consumerSecret: "");

            //app.UseFacebookAuthentication(
            //   appId: "",
            //   appSecret: "");


            //app.UseGoogleAuthentication(
            //     clientId: "1061819613782-9gp32aa3tht0f5rqdgqk5dinqr53bt7m.apps.googleusercontent.com",
            //clientSecret: "B7nw6w4edHgYzp3UIRuuhcHd"
            //);

        }
    }
}
