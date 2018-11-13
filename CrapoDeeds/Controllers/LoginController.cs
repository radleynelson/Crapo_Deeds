using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrapoDeeds.Controllers
{
    public class LoginController : Controller
    {
        //Shows login page
        public ActionResult Index()
        {
            return View ();
        }
    }
}
