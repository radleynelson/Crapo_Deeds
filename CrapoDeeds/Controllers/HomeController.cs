using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace CrapoDeeds.Controllers
{
    public class HomeController : Controller
    {
        //Index/Home page
        public ActionResult Index()
        {
            return View();
        }
    }
}
