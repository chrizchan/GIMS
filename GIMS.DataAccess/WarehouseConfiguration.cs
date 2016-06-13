using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using GIMS.Entities;

namespace GIMS.DataAccess
{
    public class WarehouseConfiguration : EntityTypeConfiguration<Warehouse>
    {
        public WarehouseConfiguration()
        {

            //HasOptional(s => s.BranchStocks).WithRequired().WillCascadeOnDelete(false);

            Property(e => e.WarehouseId)
                .IsUnicode(false);

            Property(e => e.Name)
                .IsUnicode(false);

            Property(e => e.Description)
                .IsUnicode(false);
            
        }
    }
}
