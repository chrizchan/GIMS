namespace GIMS.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class BranchStock
    {
        //public int Id { get; set; }

        [Key, Column(Order = 0)]
        [Required]
        public int ShortItemNo { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        [StringLength(50)]
        public string BranchId { get; set; }

        [Key, Column(Order = 2)]
        [Required]
        [StringLength(50)]
        public string WarehouseId { get; set; }

        public int QtyOnHand { get; set; }

        public int ReserveQty { get; set; }

        public int OpenPOQty { get; set; }

        public int ExStockAtp { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(10)]
        public string PlanCode { get; set; }

        public int? MinQty { get; set; }

        public int? MaxQty { get; set; }

        public DateTime DateUpdated { get; set; }

        public Branch Branch { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}
