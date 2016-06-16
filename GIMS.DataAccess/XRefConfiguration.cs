using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using GIMS.Entities;


namespace GIMS.DataAccess
{
    public class XRefConfiguration : EntityTypeConfiguration<XRef>
    {
        public XRefConfiguration()
        {
            Property(e => e.Type)
                .IsUnicode(false);

            HasRequired(p => p.Item)
                .WithMany(x => x.XRefs).WillCascadeOnDelete(false);

            HasRequired(p => p.XRefItem)
                .WithMany().WillCascadeOnDelete(false);

    //        HasOptional(p => p.XrefValue)
    //.WithRequired(x => x.XRef).WillCascadeOnDelete(false);

            //HasRequired(x => x.XrefValue);

            //HasOptional(p => p.XrefValue).WithRequired(x => x.XRef).WillCascadeOnDelete(false);

            //HasRequired(x => x.Item).WithMany(x => x.XRefs).WillCascadeOnDelete(false);

            //HasRequired(x => x.XRefItem).WithMany(x=>x.XRefItems).HasForeignKey(x=>x.XRefShortItemNo).WillCascadeOnDelete(false);

        }
    }
}
