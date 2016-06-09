using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GIMS.Entities
{
    public partial class Warehouse
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string WarehouseCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public DateTime DataUpdated { get; set; }
    }
}
