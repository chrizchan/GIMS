using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIMS.Web.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            PopulateDropDownList();
            return View();
        }

        private void PopulateDropDownList(int? currentId = null)
        {

            var dropdownItems = new List<SelectListItem>();
            dropdownItems.AddRange(new[]{
                            new SelectListItem() { Text = "Admin", Value = "1" },
                            new SelectListItem() { Text = "CSO", Value = "2" },
                            new SelectListItem() { Text = "BDG-Sales", Value = "3" }});


            ViewBag.UserGroups = dropdownItems;
        }
    }
}
