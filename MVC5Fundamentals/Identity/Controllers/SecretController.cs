﻿using System.Web.Mvc;

namespace Identity.Controllers
{
    //[Authorize]
    //[Authorize(Users = "pmcglone")]
    [Authorize(Roles = "admin")]
    public class SecretController : Controller
    {                
        public ActionResult Secret()
        {
            return Content("This is a secret!");
        }
        
        // Anonymous overrides the authorize attribute on the controller
        [AllowAnonymous]
        public ActionResult Overt()
        {
            return Content("This is not a secret");
        }
    }
}