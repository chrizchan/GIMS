using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIMS.Entities;
using GIMS.ServiceLayer;
using GIMS.Web.Models;

namespace GIMS.Web.Controllers
{
    public class ItemInquiryController : Controller
    {

        private readonly IItemRCInformationService _itemRCInformationService;

        public ItemInquiryController(IItemRCInformationService itemRCInformationService)
        {
            _itemRCInformationService = itemRCInformationService;
        }

        public ActionResult Index(string ItemNo2nd)
        {

            //var itemRcInformation = _itemRCInformationService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim()) ??
            //                        new ItemRCInformation();

            //var itemInquiry = new ItemInquiryVm
            //{
            //    ItemNo = itemNo,
            //    ItemRcInformation = itemRcInformation
            //};

            ViewBag.ItemNo2nd = ItemNo2nd;

            return View();
        }


        public ActionResult ItemInformationRC(string itemNo)
        {
            //var model = new ItemInquiryVm();

            //GIMS.Entities.Item a = new Item();
                
                //itemInformationRCModel = _itemRCInformationService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim());

            //var itemInformationRC = new ItemRCInformation
            //{
            //    ItemNo2nd = ""
            //};

            var itemInformationRC = _itemRCInformationService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim()) ??
                                    new ItemRCInformation();

            return PartialView("ItemInformationRC", itemInformationRC);
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
