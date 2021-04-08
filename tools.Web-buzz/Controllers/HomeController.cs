using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tools.Web_buzz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Title = "Views Dot Net | A pusher - .Net Tutorial";

            //var visitors = 0;

            //if (System.IO.File.Exists("visitors.txt"))
            //{
            //    string noOfVisitors = System.IO.File.ReadAllText("visitors.txt");
            //    visitors = Int32.Parse(noOfVisitors);
            //}

            //++visitors;

            //var visit_text = (visitors == 1) ? " view" : " views";
            //System.IO.File.WriteAllText("visitors.txt", visitors.ToString());

            //ViewData["visitors"] = visitors;
            //ViewData["visitors_txt"] = visit_text;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}