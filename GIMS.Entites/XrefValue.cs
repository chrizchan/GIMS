namespace GIMS.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class XrefValue
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShortItemNo { get; set; }

        public int Exstock { get; set; }

        public decimal LCPL { get; set; }

        public decimal SP { get; set; }

        public decimal Nett1 { get; set; }

        public DateTime DateUpdated { get; set; }

        public Item Item { get; set; }
    }
}
