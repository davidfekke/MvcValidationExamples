using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcValidationExamples.Controllers
{
    public class RemoteController : Controller
    {
        //
        // GET: /Remote/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getSomeText(string Id)
        {
            string Hello = "Hello, " + Id + "!";
            return Json(Hello, JsonRequestBehavior.AllowGet);
        }

    }
}
