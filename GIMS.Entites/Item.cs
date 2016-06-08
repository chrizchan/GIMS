using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GIMS.Entites
{
    public class Item
    {
        public Item()
        {
            BranchStocks = new HashSet<BranchStock>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShortItemNo { get; set; }

        [Required]
        [StringLength(10)]
        public string ItemNo2nd { get; set; }

        [Required]
        [StringLength(20)]
        public string GID { get; set; }

        [StringLength(10)]
        public string PricingUom { get; set; }

        [StringLength(10)]
        public string BrandOrigin { get; set; }

        [StringLength(10)]
        public string HQPlanCode { get; set; }

        [StringLength(10)]
        public string HQFamilyGroup { get; set; }

        [StringLength(10)]
        public string ProductOrigin { get; set; }

        [StringLength(10)]
        public string HQSLSCode { get; set; }

        [StringLength(50)]
        public string HQDemandCode { get; set; }

        [StringLength(50)]
        public string HQSupplyCode { get; set; }

        [StringLength(50)]
        public string LocalHQCode { get; set; }

        [StringLength(50)]
        public string LocalHQDemandCode { get; set; }

        [StringLength(50)]
        public string LocalHQFamilyGroup { get; set; }

        [StringLength(50)]
        public string LocalCode { get; set; }

        [StringLength(50)]
        public string LocalDemandCode { get; set; }

        [StringLength(50)]
        public string LocalFamilyGroup { get; set; }

        public decimal ABPrice { get; set; }

        public decimal ABPrice2 { get; set; }

        public int UnitPerCarton { get; set; }

        public decimal UnitWeight { get; set; }

        public int ExStcokAtp { get; set; }

        public int ReserveQty { get; set; }

        public int SkfExplInd { get; set; }

        public int POAtp { get; set; }

        public int GitAtp { get; set; }

        public int InspAtp { get; set; }

        public DateTime DateUpdated { get; set; }

        public ICollection<BranchStock> BranchStocks { get; set; }

        public ItemAdditionalInformation ItemAdditionalInformation { get; set; }
    }
}
