using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using GIMS.Entities;

namespace GIMS.DataAccess
{
    public class ItemAdditionalInformationConfiguration : EntityTypeConfiguration<ItemAdditionalInformation>
    {
        public ItemAdditionalInformationConfiguration()
        {
            //HasRequired(f => f.Item).WithOptional(x => x.ItemAdditionalInformation).Map(p => p.MapKey("ItemId"));
            //Property(c => c.Id).HasColumnName("ShortItemNo");

            //HasRequired(t => t.Item)
            //    .WithRequiredPrincipal(t => t.ItemAdditionalInformation);

            //HasKey(e => e.Id);
            //Property(c => c.Id).HasColumnName("ShortItemNo").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            //HasRequired(t => t.Item).WithOptional(u => u.ItemAdditionalInformation); 

            Property(e => e.Description1)
                .IsUnicode(false);

            Property(e => e.Description2)
                .IsUnicode(false);

            Property(e => e.Description3)
                .IsUnicode(false);

            Property(e => e.Description3a)
                .IsUnicode(false);

            Property(e => e.HqHsCode)
                .IsUnicode(false);

            Property(e => e.Detail1)
                .IsUnicode(false);
        }
    }
}
