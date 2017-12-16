using nymity.codetest.domain.Model;
using System.Data.Entity;
using nymity.codetest.infra.EntityConfiguration;

namespace nymity.codetest.infra.Context
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
            :base("Northwind")
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CategoryConfiguration());          
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());            
        }

    }
}
