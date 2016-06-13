using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIMS.Entities;
using GIMS.Repository;
using GIMS.ServiceLayer;
using GIMS.Web.Models;

namespace GIMS.Web.Controllers
{
    public class ItemInquiryController : Controller
    {

        private readonly IItemService _itemService;
        private readonly IItemRCInformationService _itemRCInformationService;
        private readonly IItemAdditionalInformationService _itemAdditionalInformationService;
        private readonly IHQStockStatusService _hqStockStatusService;
        private readonly IBranchStockRepository _branchStockService;

        public ItemInquiryController(IItemRCInformationService itemRCInformationService, 
                                        IItemAdditionalInformationService itemAdditionalInformationService, 
                                        IItemService itemService,
                                        IHQStockStatusService hqStockStatusService,
                                        IBranchStockRepository branchStockService)
        {
            _itemRCInformationService = itemRCInformationService;
            _itemAdditionalInformationService = itemAdditionalInformationService;
            _itemService = itemService;
            _hqStockStatusService = hqStockStatusService;
            _branchStockService = branchStockService;
        }

        public ActionResult Index(string ItemNo2nd)
        {
            ViewBag.ItemNo2nd = ItemNo2nd;

            return View();
        }


        [ChildActionOnly]
        public ActionResult ItemInformationRC(string itemNo)
        {

            var itemInformationRC = _itemRCInformationService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim()) ??
                                    new ItemRCInformation
                                    {
                                        ItemNo2nd = itemNo
                                    };

            return PartialView("ItemInformationRC", itemInformationRC);
        }

        [ChildActionOnly]
        public ActionResult AdditionalInformation(string itemNo)
        {

            var shortItemNo = _itemService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim()) == null
                ? 0
                : _itemService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim()).ShortItemNo;

            var itemAdditionalInformation = _itemAdditionalInformationService.Get(x => x.ShortItemNo == shortItemNo) ??
                                    new ItemAdditionalInformation();

            return PartialView("AdditionalInformation", itemAdditionalInformation);
        }

        [ChildActionOnly]
        public ActionResult StockStatus(string itemNo)
        {
            var shortItemNo = _itemService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim()) == null
                                ? 0
                                : _itemService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim()).ShortItemNo;


            var hqStockStatusInformation = _hqStockStatusService.GetMany(x => x.ShortItemNo == shortItemNo) ;

            return PartialView("StockStatus", hqStockStatusInformation.ToList());
        }

        [ChildActionOnly]
        public ActionResult BranchStocks(string itemNo)
        {
            var shortItemNo = _itemService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim()) == null
                    ? 0
                    : _itemService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim()).ShortItemNo;

            var list = _branchStockService.GetBranchStockList(shortItemNo, x => x.Branch,x=>x.Warehouse);

            return PartialView("BranchStocks", list);
        }

        [ChildActionOnly]
        public ActionResult CrossReferenceList(string itemNo)
        {
            var shortItemNo = _itemService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim()) == null
                    ? 0
                    : _itemService.Get(x => x.ItemNo2nd.Trim() == itemNo.Trim()).ShortItemNo;

            var list = _branchStockService.GetBranchStockList(shortItemNo, x => x.Branch, x => x.Branch.BranchStocks);

            return PartialView("BranchStocks", list);
        }

    }
}
