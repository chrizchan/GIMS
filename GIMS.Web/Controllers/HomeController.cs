using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIMS.ServiceLayer;
using Microsoft.Web.Mvc;

namespace GIMS.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IItemService _itemService;
        private readonly IItemAdditionalInformationService _itemAdditionalInformationService;


        public HomeController(IItemService itemService, IItemAdditionalInformationService itemAdditionalInformationService)
        {
            _itemService = itemService;
            _itemAdditionalInformationService = itemAdditionalInformationService;
        }

        public ActionResult Index()
        {
            var x1 = _itemAdditionalInformationService.GetAll();
            var t1 = _itemService.GetAll().ToList();
            var a = _itemService.GetAll(x=>x.ItemAdditionalInformation).ToList();
            var b = a.Count();

            foreach (var item in a)
            {
                var c = a;
            }

            

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
