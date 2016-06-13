using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace GIMS.Entities
{
    public class Warehouse
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int Id { get; set; }

        [Key, Column(Order = 0)]
        [Required]
        [StringLength(50)]
        public string BranchId { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        [StringLength(50)]
        public string WarehouseId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public DateTime DataUpdated { get; set; }        
    }
}
