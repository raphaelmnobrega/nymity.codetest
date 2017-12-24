using nymity.codetest.domain.Model;
using System.Data.Entity;
using nymity.codetest.infra.EntityConfiguration;

namespace nymity.codetest.infra.Context
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
            :base("NORTHWND")
        {
            
        }
       
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CategoryConfiguration());          
            modelBuilder.Configurations.Add(new ProductConfiguration());           
        }

    }
}
