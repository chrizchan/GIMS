
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}
