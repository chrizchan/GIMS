using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIMS.Web.Controllers
{
    public class AutoBillGroupController : Controller
    {
        //
        // GET: /AutoBillGroup/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

    }
}
