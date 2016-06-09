namespace GIMS.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class HQStockStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShortItemNo { get; set; }

        [Required]
        [StringLength(50)]
        public string WarehouseCode { get; set; }

        public int Reservation { get; set; }

        public int ExStockAtp { get; set; }

        [StringLength(50)]
        public string WIP { get; set; }

        public int QtyTransferTo { get; set; }

        public int POAtp { get; set; }

        public int GITAtp { get; set; }

        public int INSPAtp { get; set; }

        public int GITRf { get; set; }

        public DateTime? GITDate { get; set; }
    }
}
