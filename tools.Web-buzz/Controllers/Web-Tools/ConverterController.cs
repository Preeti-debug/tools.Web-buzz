using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tools.Web_buzz.Controllers.Web_Tools
{
    public class ConverterController : Controller
    {
        // GET: Converter
        public ActionResult WeightConverter()
        {
            return View();
        }
        public ActionResult TemperatureConverter()
        {
            return View();
        }
    }
}