namespace GIMS.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemSgInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShortItemNo { get; set; }

        public decimal? ListN { get; set; }

        public decimal? ListN2 { get; set; }

        public decimal? BWAC { get; set; }

        public int? UnitPerCarton { get; set; }

        public decimal? LCPL { get; set; }

        public decimal? LCPL11 { get; set; }

        public decimal? AU { get; set; }

        public decimal? AU2 { get; set; }

        public decimal? LCPE { get; set; }

        public decimal? LCPE11 { get; set; }

        public decimal? SP { get; set; }

        public decimal? SP11 { get; set; }

        public decimal? SKFSPL { get; set; }

        public decimal? SKFSPL11 { get; set; }

        public decimal? LCPE2 { get; set; }

        public decimal? LCPE211 { get; set; }

        public decimal? Nett1 { get; set; }

        public decimal? Nett111 { get; set; }

        public decimal? SKFEXPL { get; set; }

        public decimal? Nett2 { get; set; }

        public decimal? Nett211 { get; set; }

        public decimal? Last12MonthlySelling { get; set; }

        public decimal? Last12AverageSelling { get; set; }

        public int? UnitWeight { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
