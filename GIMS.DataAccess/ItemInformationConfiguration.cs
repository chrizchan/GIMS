using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using GIMS.Entities;

namespace GIMS.DataAccess
{
    public class ItemInformationConfiguration : EntityTypeConfiguration<ItemRCInformation>
    {
        public ItemInformationConfiguration()
        {
            //Property(c => c.Id).HasColumnName("ShortItemNo").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //HasOptional(s => s.ItemAdditionalInformation) // Mark Address property optional in Student entity
            //    .WithRequired(ad => ad.Item);

            //HasOptional(e => e.ItemAdditionalInformation)
            //    .WithRequired(e => e.Item);

            //HasKey(e => e.Id);

            //Property(c => c.ItemNo2nd)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //HasOptional(x => x.ItemAdditionalInformation).WithMany().HasForeignKey(x => x.ItemAdditionalInformationId);

            Property(e => e.ItemNo2nd)
                 .IsUnicode(false);

            Property(e => e.GID)
                .IsUnicode(false);

            Property(e => e.PricingUom)
                .IsUnicode(false);

            Property(e => e.BrandOrigin)
                .IsUnicode(false);

            Property(e => e.HQPlanCode)
                .IsUnicode(false);

            Property(e => e.HQFamilyGroup)
                .IsUnicode(false);

            Property(e => e.ProductOrigin)
                .IsUnicode(false);

            Property(e => e.HQSLSCode)
                .IsUnicode(false);

            Property(e => e.HQDemandCode)
                .IsUnicode(false);

            Property(e => e.HQSupplyCode)
                .IsUnicode(false);

            Property(e => e.LocalHQCode)
                .IsUnicode(false);

            Property(e => e.LocalHQDemandCode)
                .IsUnicode(false);

            Property(e => e.LocalHQFamilyGroup)
                .IsUnicode(false);

            Property(e => e.LocalCode)
                .IsUnicode(false);

            Property(e => e.LocalDemandCode)
                .IsUnicode(false);

            Property(e => e.LocalFamilyGroup)
                .IsUnicode(false);

            HasMany(e => e.BranchStocks)
                .WithRequired(e => e.ItemRcInformation)
                .WillCascadeOnDelete(false);

            HasOptional(e => e.ItemAdditionalInformation)
                .WithRequired(e => e.ItemRcInformation);
        }
    }
}
