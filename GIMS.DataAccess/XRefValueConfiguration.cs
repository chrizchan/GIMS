using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using GIMS.Entities;

namespace GIMS.DataAccess
{
    public class XRefValueConfiguration : EntityTypeConfiguration<XrefValue>
    {
        public XRefValueConfiguration()
        {
            HasRequired(p => p.Item)
                .WithOptional().WillCascadeOnDelete(false);

            //HasRequired(p => p.XRef)
            //    .WithOptional().WillCascadeOnDelete(false);
        }
    }
}
