using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GIMS.ViewModel.Item
{
    public class ItemSearchListViewModel
    {


        [Key]
        public int ShortItemNo { get; set; }

        [StringLength(50)]
        public string ItemNo2nd { get; set; }

        [StringLength(50)]
        public string XrefItemNo { get; set; }

        public int XrefShortItemNo { get; set; }

        [StringLength(50)]
        public string XType { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        [StringLength(10)]
        public string BrandGroup { get; set; }

        public int? GpQtyAvail { get; set; }

        [StringLength(100)]
        public string Description1 { get; set; }

        [StringLength(100)]
        public string Description2 { get; set; }

        [StringLength(50)]
        public string Searchtext { get; set; }

        [StringLength(50)]
        public string MajorType { get; set; }

        [StringLength(50)]
        public string GItemNo2nd { get; set; }

        public DateTime DateUpdated { get; set; }


        public int TotalStocksSGP { get; set; }
        public int TotalStocksCHN { get; set; }
        public int TotalStocksIDN { get; set; }
        public int TotalStocksMNG { get; set; }
        public int TotalStocksMYS { get; set; }
        public int TotalStocksOthers { get; set; }

    }
}
