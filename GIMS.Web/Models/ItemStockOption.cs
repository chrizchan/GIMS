using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIMS.Web.Models
{
    public class ItemStockOption
    {
        public string ItemNo { get; set; }
        public string XRef { get; set; }
        public string SearchText { get; set; }
        public string Brand { get; set; }
        public string BrandGroup { get; set; }
        public string MajorType { get; set; }

        public bool IsXref { get; set; }
        public bool IsStockByCountry { get; set; }
    }
}