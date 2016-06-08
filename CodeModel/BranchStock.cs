namespace CodeModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BranchStock
    {
        public int Id { get; set; }

        public int ShortItemNo { get; set; }

        [Required]
        [StringLength(50)]
        public string BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string WarehouseCode { get; set; }

        public int GID { get; set; }

        public int QtyOnHand { get; set; }

        public int ReserveQty { get; set; }

        public int OpenPOQty { get; set; }

        public int ExStockAtp { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [StringLength(10)]
        public string PlanCode { get; set; }

        public DateTime DateUpdated { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Item Item { get; set; }
    }
}
