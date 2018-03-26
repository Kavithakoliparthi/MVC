using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class ViewBagDemoController : Controller
    {
        // GET: ViewBag
        public ActionResult Index()
        {
            List<string> Courses = new List<string>();
            Courses.Add("J2SE");
            Courses.Add("J2EE");
            Courses.Add("Spring");
            Courses.Add("Hibernates");
            ViewData["Courses"] = Courses;
                    //ViewBag
            //ViewBag.Courses = Courses;
                    //TemplateData
            //TempData["Courses"] = Courses;
            return View();
        }
    }
}