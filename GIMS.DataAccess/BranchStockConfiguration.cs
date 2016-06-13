using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using GIMS.Entities;

namespace GIMS.DataAccess
{
    public class BranchStockConfiguration : EntityTypeConfiguration<BranchStock>
    {
        public BranchStockConfiguration()
        {
            //HasKey(c => new { c.ShortItemNo, c.WarehouseCode, c.BranchId });

            //HasRequired(t => t.Item).WithMany(x=>x.BranchStocks).WillCascadeOnDelete(false);
            //HasRequired(t => t.Warehouse).WithMany(x => x.BranchStocks).WillCascadeOnDelete(false);
            //HasRequired(t => t.Branch).WithMany(x => x.BranchStocks).WillCascadeOnDelete(false);


            //HasRequired(p => p.F01030)
            //.WithMany(c => c.F42020s)
            //.HasForeignKey(c => new { c.CustomerID });

            ////HasRequired(p => p.Item)
            ////.WithMany(c => c.BranchStocks)
            ////.HasForeignKey(c => new { c.ShortItemNo });

            //HasRequired(p => p.F42020)
            //.WithMany(c => c.F42021s)
            //.HasForeignKey(c => new { c.CoID, c.DocType, c.DocNo });

            //HasRequired(p => p.Branch)
            //.WithMany(c => c.BranchStocks)
            //.HasForeignKey(c => new { c.BranchId });

            //HasRequired(p => p.Warehouse)
            //.WithMany(c => c.BranchStocks)
            //.HasForeignKey(c => new { c.WarehouseCode, c.BranchId });

            //HasRequired(p => p.Item)
            //.WithMany(c => c.BranchStocks)
            //.HasForeignKey(c => new { c.ShortItemNo });

            Property(e => e.BranchId)
             .IsUnicode(false);

            Property(e => e.WarehouseId)
                .IsUnicode(false);

            Property(e => e.UOM)
                .IsUnicode(false);

            Property(e => e.PlanCode)
                .IsUnicode(false);

            HasRequired(p => p.Warehouse)
                .WithMany().WillCascadeOnDelete(false);

            HasRequired(p => p.Branch)
                .WithMany().WillCascadeOnDelete(false);


        }
    }
}
