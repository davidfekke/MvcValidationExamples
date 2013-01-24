using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcValidationExamples.Controllers
{
    public class TabsController : Controller
    {
        //
        // GET: /Tabs/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SecondTab()
        {
            return PartialView();
        }

        public ActionResult ThirdTab()
        {
            return PartialView();
        }

    }
}
