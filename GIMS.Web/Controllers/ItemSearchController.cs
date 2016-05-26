using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIMS.Web.Models;

namespace GIMS.Web.Controllers
{
    public class ItemSearchController : Controller
    {
        //
        // GET: /ItemSearch/

        public ActionResult Index(ItemStockOption model)
        {
            return View(model);
        }

    }
}
