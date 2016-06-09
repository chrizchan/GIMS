using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using GIMS.Entities;

namespace GIMS.DataAccess
{
    public class ItemConfiguration : EntityTypeConfiguration<Item>
    {
        public ItemConfiguration()
        {
            Property(e => e.ItemNo2nd)
                .IsUnicode(false);



            Property(e => e.Brand)
                .IsUnicode(false);

            Property(e => e.BrandGroup)
                .IsFixedLength();

            Property(e => e.Description1)
                .IsUnicode(false);

            Property(e => e.Description2)
                .IsUnicode(false);

            Property(e => e.Searchtext)
                .IsUnicode(false);

            Property(e => e.MajorType)
                .IsUnicode(false);

            Property(e => e.GItemNo2nd)
                .IsUnicode(false);
        }
    }
}
