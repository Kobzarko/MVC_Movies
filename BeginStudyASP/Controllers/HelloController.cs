using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeginStudyASP.Controllers
{
    public class HelloController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numtimes=5)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.Numtimes = numtimes;

            return View();
        }
    }
}