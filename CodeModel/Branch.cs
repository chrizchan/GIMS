namespace CodeModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Branch
    {
        public Branch()
        {
            BranchStocks = new HashSet<BranchStock>();
        }

        [StringLength(50)]
        public string BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        [StringLength(10)]
        public string DateUpdated { get; set; }

        public virtual ICollection<BranchStock> BranchStocks { get; set; }
    }
}
