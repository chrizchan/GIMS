using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using GIMS.Entities;

namespace GIMS.DataAccess
{
    public class HQStockStatusConfirguration : EntityTypeConfiguration<HQStockStatus>
    {
        public HQStockStatusConfirguration()
        {

            ToTable("HQStockStatuses");

            Property(e => e.WarehouseCode)
                .IsUnicode(false);

            Property(e => e.WIP)
                .IsUnicode(false);
        }
    }
}
