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

            HasRequired(x => x.Item).WithMany(x => x.XRefs);



        }
    }
}
