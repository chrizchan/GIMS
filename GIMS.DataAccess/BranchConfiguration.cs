using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using GIMS.Entites;

namespace GIMS.DataAccess
{
    public class BranchConfiguration : EntityTypeConfiguration<Branch>
    {
        public BranchConfiguration()
        {
            Property(e => e.BranchId)
                           .IsUnicode(false);

            Property(e => e.Name)
                .IsUnicode(false);

            Property(e => e.Description)
                .IsUnicode(false);

            Property(e => e.DateUpdated)
                .IsFixedLength();

            HasMany(e => e.BranchStocks)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);
        }
    }
}
