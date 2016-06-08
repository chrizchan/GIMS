using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIMS.Web.Controllers
{
    public class UserRequisitionController : Controller
    {
        //
        // GET: /UserRequisition/

        public ActionResult Index()
        {
            
            return View();
        }

        private void PopulateDropDownList()
        {
            var dropdownStatus = new List<SelectListItem>();
            dropdownStatus.AddRange(new[]
            {
                new SelectListItem() { Text = "Pending", Value = "1" },
                new SelectListItem() { Text = "Approved", Value = "2" }
            });

            var dropdownApprovers = new List<SelectListItem>();
            dropdownApprovers.AddRange(new[]
            {
                new SelectListItem() { Text = "John Doe", Value = "1" },
                new SelectListItem() { Text = "Harr Smith", Value = "2" }
            });


            ViewBag.Status = dropdownStatus;
            ViewBag.Approvers = dropdownApprovers;
        }

        [HttpGet]
        public ActionResult Create()
        {
            PopulateDropDownList();
            return View();
        }

    }
}
