namespace CodeModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GimsDataContext : DbContext
    {
        public GimsDataContext()
            : base("name=GimsDataContext")
        {
        }

        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchStock> BranchStocks { get; set; }
        public virtual DbSet<ItemAdditionalInformation> ItemAdditionalInformations { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>()
                .Property(e => e.BranchId)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.DateUpdated)
                .IsFixedLength();

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.BranchStocks)
                .WithRequired(e => e.Branch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BranchStock>()
                .Property(e => e.BranchId)
                .IsUnicode(false);

            modelBuilder.Entity<BranchStock>()
                .Property(e => e.WarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<BranchStock>()
                .Property(e => e.UOM)
                .IsUnicode(false);

            modelBuilder.Entity<BranchStock>()
                .Property(e => e.PlanCode)
                .IsUnicode(false);

            modelBuilder.Entity<ItemAdditionalInformation>()
                .Property(e => e.Desctiption1)
                .IsUnicode(false);

            modelBuilder.Entity<ItemAdditionalInformation>()
                .Property(e => e.Desctiption2)
                .IsUnicode(false);

            modelBuilder.Entity<ItemAdditionalInformation>()
                .Property(e => e.Desctiption3)
                .IsUnicode(false);

            modelBuilder.Entity<ItemAdditionalInformation>()
                .Property(e => e.Desctiption3a)
                .IsUnicode(false);

            modelBuilder.Entity<ItemAdditionalInformation>()
                .Property(e => e.HqHsCode)
                .IsUnicode(false);

            modelBuilder.Entity<ItemAdditionalInformation>()
                .Property(e => e.Detail1)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.ItemNo2nd)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.PricingUom)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.BrandOrigin)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.HQPlanCode)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.HQFamilyGroup)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.ProductOrigin)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.HQSLSCode)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.HQDemandCode)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.HQSupplyCode)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.LocalHQCode)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.LocalHQDemandCode)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.LocalHQFamilyGroup)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.LocalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.LocalDemandCode)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.LocalFamilyGroup)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.BranchStocks)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasOptional(e => e.ItemAdditionalInformation)
                .WithRequired(e => e.Item);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.BranchId)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.WarehouseCode)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
