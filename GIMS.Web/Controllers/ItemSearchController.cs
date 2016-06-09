using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIMS.Entities;
using GIMS.ServiceLayer;
using GIMS.ViewModel.Item;
using GIMS.Web.Models;
using PagedList;

namespace GIMS.Web.Controllers
{
    public class ItemSearchController : Controller
    {

        private readonly IItemService _itemService;
        private readonly IXRefService _xRefService;
        public ItemSearchController(IItemService itemService, IXRefService xRefService)
        {
            _itemService = itemService;
            _xRefService = xRefService;
        }

        public ActionResult Index(ItemStockOption model, string sort, string search, int? page)
        {

            ViewBag.ItemNo = model.ItemNo;
            ViewBag.IsXref = model.IsXref;
            ViewBag.Brand = model.Brand;
            ViewBag.IsStockByCountry = model.IsStockByCountry;
            ViewBag.XRef = model.XRef;
            ViewBag.MajorType = model.MajorType;
            ViewBag.SearchText = model.SearchText;
            ViewBag.BrandGroup = model.BrandGroup;

            //var a = _itemService.GetAllItemSearchList();

            //IQueryable<Item> items = _itemService.GetAll(x=>x.Xref);
            //IQueryable<ItemSearchListViewModel> items = _itemService.GetAllItemSearchList(x => x.XrefValue);
            IQueryable<ItemSearchListViewModel> items = _xRefService.GetAllItemSearchList(x => x.Item);

            if (!String.IsNullOrEmpty(model.ItemNo))
                items = items.Where(ii => ii.ItemNo2nd.StartsWith(model.ItemNo));

            if (!String.IsNullOrEmpty(model.Brand))
                items = items.Where(ii => ii.Brand.StartsWith(model.Brand));

            if (!String.IsNullOrEmpty(model.XRef))
                items = items.Where(ii => ii.XrefItemNo.StartsWith(model.XRef));

            if (!String.IsNullOrEmpty(model.MajorType))
                items = items.Where(ii => ii.MajorType.StartsWith(model.MajorType));

            if (!String.IsNullOrEmpty(model.SearchText))
                items = items.Where(ii => ii.Searchtext.StartsWith(model.SearchText));

            if (!String.IsNullOrEmpty(model.BrandGroup))
                items = items.Where(ii => ii.BrandGroup.StartsWith(model.BrandGroup));

            items = items.OrderBy(ii => ii.ShortItemNo);

            int pageSize = 15;
            int pageNumber = page ?? 1;

            var result = items.ToPagedList(pageNumber, pageSize);


            return View(result);
        }

    }
}
