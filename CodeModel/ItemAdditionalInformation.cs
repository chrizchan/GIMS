namespace CodeModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemAdditionalInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShortItemNo { get; set; }

        [StringLength(100)]
        public string Desctiption1 { get; set; }

        [StringLength(100)]
        public string Desctiption2 { get; set; }

        [StringLength(100)]
        public string Desctiption3 { get; set; }

        [StringLength(100)]
        public string Desctiption3a { get; set; }

        [StringLength(50)]
        public string HqHsCode { get; set; }

        [StringLength(50)]
        public string Detail1 { get; set; }

        public DateTime DateUpdated { get; set; }

        public virtual Item Item { get; set; }
    }
}