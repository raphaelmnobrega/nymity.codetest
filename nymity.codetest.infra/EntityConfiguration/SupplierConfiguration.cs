using System.Data.Entity.ModelConfiguration;
using nymity.codetest.domain.Model;

namespace nymity.codetest.infra.EntityConfiguration
{
    public class SupplierConfiguration : EntityTypeConfiguration<Supplier>
    {
        public SupplierConfiguration()
        {
            ToTable("Suppliers");
            HasKey(x => x.SupplierId);

            Property(x => x.SupplierId).HasColumnName(@"SupplierID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyName).HasColumnName(@"CompanyName").HasColumnType("nvarchar").IsRequired().HasMaxLength(40);
            Property(x => x.ContactName).HasColumnName(@"ContactName").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.ContactTitle).HasColumnName(@"ContactTitle").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Address).HasColumnName(@"Address").HasColumnType("nvarchar").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Region).HasColumnName(@"Region").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName(@"PostalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Country).HasColumnName(@"Country").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.Phone).HasColumnName(@"Phone").HasColumnType("nvarchar").IsOptional().HasMaxLength(24);
            Property(x => x.Fax).HasColumnName(@"Fax").HasColumnType("nvarchar").IsOptional().HasMaxLength(24);
            Property(x => x.HomePage).HasColumnName(@"HomePage").HasColumnType("ntext").IsOptional().IsMaxLength();
        }
    }
}
