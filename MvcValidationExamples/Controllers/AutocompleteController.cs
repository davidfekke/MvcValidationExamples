using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcValidationExamples.Controllers
{
    public class AutocompleteController : Controller
    {
        //
        // GET: /Autocomplete/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sample()
        {
            return View();
        }

        public ActionResult GetLanguages()
        {
            string[] availableTags = new string[22] { "ActionScript",
			"AppleScript",
			"Asp",
			"BASIC",
			"C",
			"C++",
			"Clojure",
			"COBOL",
			"ColdFusion",
			"Erlang",
			"Fortran",
			"Groovy",
			"Haskell",
			"Java",
			"JavaScript",
			"Lisp",
			"Perl",
			"PHP",
			"Python",
			"Ruby",
			"Scala",
			"Scheme" };
            return Json(availableTags, JsonRequestBehavior.AllowGet);
        }

    }
}
