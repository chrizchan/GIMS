using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIMS.Web.Models;

namespace GIMS.Web.Controllers
{
    public class ItemInquiryController : Controller
    {
        //
        // GET: /ItemPrice/

        public ActionResult Index(string itemNo)
        {
            var itemInquiry = new ItemInquiryVm
            {
                ItemNo = itemNo,
                ItemAdditionalInformationVm = new ItemAdditionalInformationVm()
            };

            ViewBag.ItemNo2nd = itemNo;
            return View(itemInquiry);
        }

        [ChildActionOnly]
        public ActionResult ItemInformationRC(string itemNo)
        {
            var model = new ItemInquiryVm();

            return PartialView("ItemInformationRC", model);
        }

        [ChildActionOnly]
        public ActionResult AdditionalInformation(string itemNo)
        {
            var model = new ItemAdditionalInformationVm();

            return PartialView("AdditionalInformation", model);
        }

        [ChildActionOnly]
        public ActionResult StockStatus(string itemNo)
        {

            return PartialView("StockStatus");
        }

    }
}
