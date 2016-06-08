
using System.Data.Entity;
using GIMS.DataAccess;


namespace GIMS.Entites
{
    public class GIMSContext : DbContext
    {
        public GIMSContext()
            : base("name=GIMSContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemAdditionalInformation> ItemAdditionalInformations { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<BranchStock> BranchStocks { get; set; }
        public DbSet<Branch> Branches { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new ItemConfiguration());
            modelBuilder.Configurations.Add(new ItemAdditionalInformationConfiguration());
            modelBuilder.Configurations.Add(new BranchStockConfiguration());
            modelBuilder.Configurations.Add(new BranchConfiguration());
            modelBuilder.Configurations.Add(new WarehouseConfiguration());
        }
    }
}
