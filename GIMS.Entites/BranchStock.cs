using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GIMS.Entites
{
    public class BranchStock
    {
        public int Id { get; set; }

        public int ShortItemNo { get; set; }

        [Required]
        [StringLength(50)]
        public string BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string WarehouseCode { get; set; }

        public int QtyOnHand { get; set; }

        public int ReserveQty { get; set; }

        public int OpenPOQty { get; set; }

        public int ExStockAtp { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(10)]
        public string PlanCode { get; set; }

        public DateTime DateUpdated { get; set; }

        public Branch Branch { get; set; }

        public Item Item { get; set; }
    }
}
