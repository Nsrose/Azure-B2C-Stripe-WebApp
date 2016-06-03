using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using WebApp_OpenIDConnect_DotNet_B2C.Policies;

namespace WebApp_OpenIDConnect_DotNet_B2C.Controllers
{
    public class PremiumController : Controller
    {
        [PolicyAuthorize(Policy = "b2c_1_sign-in-policy")]
        public ActionResult Index()
        {
            //ViewBag.StripePublicKey = Startup.StripePublicKey;
            ViewBag.StripePublicKey = Startup.StripePublicKey;
            Claim StripeCustomerID = ClaimsPrincipal.Current.FindFirst("extension_9447bec1394f4faa9b8fb17bcb35c028_stripe_customer_id");
            ViewBag.StripeCustomerID = StripeCustomerID.Value;
            return View();
        }

        [PolicyAuthorize(Policy = "b2c_1_sign-in-policy")]
        public ActionResult Charge()
        {
            //ViewBag.StripePublicKey = Startup.StripePublicKey;
            ViewBag.StripePublicKey = Startup.StripePublicKey;
            return View();
        }



        public ActionResult Error(string message)
        {
            ViewBag.Message = message;

            return View("Error");
        }
    }
}