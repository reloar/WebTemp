using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using WebTemp.Models;

namespace WebTemp.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        // GET: Auth

            [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Logout()
        {
            var ctxt = this.Request.GetOwinContext();
            ctxt.Authentication.SignOut("ApplicationCookie");

            return Redirect("Login");
        }

        [HttpPost]
        public ActionResult Login(LoginInfo loginInfo)
        {
            //returnUrl=Request.QueryString["returnUrl"];
            string username = "admin@cybsoft.com";
            string password = "admin";
            if (this.ModelState.IsValid)
            {
                if (username.Equals(loginInfo.Username) && password.Equals(loginInfo.Password))
                {
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity("AppCookie");
                    claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, loginInfo.Username));

                    var ctxt = this.Request.GetOwinContext();
                    ctxt.Authentication.SignIn(claimsIdentity);
                    return Redirect(GetRedirectUrl(loginInfo.ReturnUrl));
                }
                else
                {
                    this.ModelState.AddModelError("", "Invalid Username or Password");
                }
            }
            return View(loginInfo);
        }

        [HttpGet]
        public ActionResult Login()
        {
            var model = new LoginInfo();
            return View(model);
        }
        private string GetRedirectUrl(string returnUrl)
        {
            if(string.IsNullOrEmpty(returnUrl)||!Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("Index", "Home");
            }
            return returnUrl;
        }

       


    }
}