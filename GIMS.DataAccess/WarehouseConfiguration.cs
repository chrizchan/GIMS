using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using GIMS.Entites;

namespace GIMS.DataAccess
{
    public class WarehouseConfiguration : EntityTypeConfiguration<Warehouse>
    {
        public WarehouseConfiguration()
        {

            //HasOptional(s => s.BranchStocks).WithRequired().WillCascadeOnDelete(false);
            Property(e => e.BranchId)
                .IsUnicode(false);

            Property(e => e.WarehouseCode)
                .IsUnicode(false);

            Property(e => e.Name)
                .IsUnicode(false);

            Property(e => e.Description)
                .IsUnicode(false);
            
        }
    }
}
