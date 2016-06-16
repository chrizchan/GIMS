namespace GIMS.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Item
    {

        public Item()
        {
            XRefs = new List<XRef>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShortItemNo { get; set; }

        [StringLength(50)]
        public string ItemNo2nd { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        [StringLength(10)]
        public string BrandGroup { get; set; }

        public int? GpQtyAvail { get; set; }

        [StringLength(100)]
        public string Description1 { get; set; }

        [StringLength(100)]
        public string Description2 { get; set; }

        [StringLength(50)]
        public string Searchtext { get; set; }

        [StringLength(50)]
        public string MajorType { get; set; }

        [StringLength(50)]
        public string GItemNo2nd { get; set; }

        public DateTime DateUpdated { get; set; }

        public List<XRef> XRefs { get; set; }

        [ForeignKey("ShortItemNo")]
        public XrefValue XrefValue { get; set; }

    }
}
