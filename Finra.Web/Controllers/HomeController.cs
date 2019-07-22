using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Finra.Core;

namespace Finra.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            long input = 2403866106;
            AlphaNumericGenerator generator = new AlphaNumericGenerator();
            var output = generator.GetAlphaNumerics(input, 1, 10);
            ViewBag.TotalCount = output.Item1;
            ViewBag.AlphaNumerics = output.Item2;
            return View(); 
        }
    }
}