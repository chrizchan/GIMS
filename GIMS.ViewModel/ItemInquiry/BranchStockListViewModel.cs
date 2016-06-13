using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using GIMS.Entities;

namespace GIMS.ViewModel.ItemInquiry
{
    public class BranchStockListViewModel
    {
        public string BranchName { get; set; }
        public int Reservation { get; set; }
        public int ExStockAtp { get; set; }

        [Key]
        public string BranchId { get; set; }

        public IList<BranchStock> BranchStocks { get; set; }

        //public IList<BranchStock> BranchStockList
        //{
        //    get
        //    {
        //       return BranchStocks == null ? null : BranchStocks.ToList();
        //    }
        //}
    }
}
