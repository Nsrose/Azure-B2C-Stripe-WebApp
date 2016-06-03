using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using WebApp_OpenIDConnect_DotNet_B2C.Policies;
using Stripe;

namespace WebApp_OpenIDConnect_DotNet_B2C.Controllers
{
    public class PricingController : Controller
    {
        [PolicyAuthorize(Policy = "b2c_1_sign-in-policy")]
        public ActionResult Index()
        {
            //ViewBag.StripePublicKey = Startup.StripePublicKey;
            ViewBag.StripePublicKey = Startup.StripePublicKey;
            return View();
        }

        [PolicyAuthorize(Policy = "b2c_1_sign-in-policy")]
        public ActionResult Charge()
        {
            //claims = ClaimsPrincipal.Current.FindFirst("Email");

            //var UserEmail = ClaimsPrincipal.Current.FindFirst("emails").Value;
           
            //var Customer = new StripeCustomerCreateOptions();
           
           

            return View();
        }



        public ActionResult Error(string message)
        {
            ViewBag.Message = message;

            return View("Error");
        }
    }
}