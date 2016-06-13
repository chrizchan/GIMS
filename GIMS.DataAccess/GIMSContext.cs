
using System.Data.Entity;
using GIMS.Entities;


namespace GIMS.DataAccess
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

        public  DbSet<Branch> Branches { get; set; }
        public  DbSet<BranchStock> BranchStocks { get; set; }
        public DbSet<HQStockStatus> HQStockStatuses { get; set; }
        public  DbSet<Item> Items { get; set; }
        public  DbSet<ItemAdditionalInformation> ItemAdditionalInformations { get; set; }
        public  DbSet<ItemRCInformation> ItemRCInformations { get; set; }
        public  DbSet<ItemSgInformation> ItemSgInformations { get; set; }
        public  DbSet<Warehouse> Warehouses { get; set; }
        public  DbSet<XrefValue> XrefValues { get; set; }
        public DbSet<XRef> Xrefs { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new ItemRCInformationConfiguration());
            modelBuilder.Configurations.Add(new ItemAdditionalInformationConfiguration());
            //modelBuilder.Configurations.Add(new ItemSgConfiguration());
            modelBuilder.Configurations.Add(new BranchStockConfiguration());
            modelBuilder.Configurations.Add(new BranchConfiguration());
            modelBuilder.Configurations.Add(new WarehouseConfiguration());
            modelBuilder.Configurations.Add(new XRefValueConfiguration());
            modelBuilder.Configurations.Add(new HQStockStatusConfirguration());
            modelBuilder.Configurations.Add(new ItemConfiguration());
            modelBuilder.Configurations.Add(new XRefConfiguration());
        }
    }
}
