using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.Mvc;

namespace GIMS.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SayHello(string name)
        {
            var model = new SayHelloViewModel
            {
                Name = name
            };

            return View(model);
        }


        [HttpPost]
        public ActionResult SayHello(SayHelloForm form)
        {
            //return this.RedirectToAction(c => c.SayHello("asd"));
            //return null;

            return RedirectToAction("SayHello", new {name = form.Name});
        }
    }


	public class SayHelloForm
	{
		public string Name { get; set; }
	}
    public class SayHelloViewModel
    {
        public string Name { get; set; }
    }
}
