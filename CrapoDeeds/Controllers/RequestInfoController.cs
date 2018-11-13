using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrapoDeeds.Controllers
{
    public class RequestInfoController : Controller
    {
        //Shows Form for customer to create lead
        public ActionResult Index()
        {
            return View();
        }
    }
}
