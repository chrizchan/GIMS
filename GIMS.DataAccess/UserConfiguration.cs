﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using GIMS.Entites;

namespace GIMS.DataAccess
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(c => new { c.Id });

            Property(c => c.Id)
                .IsRequired();

            Property(c => c.Username)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.EmailAddress)
                .IsRequired()
                .HasMaxLength(100);


        }
    }
}
