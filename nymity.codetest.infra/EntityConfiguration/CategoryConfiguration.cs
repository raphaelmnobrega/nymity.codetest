using System.Data.Entity.ModelConfiguration;
using nymity.codetest.domain.Model;

namespace nymity.codetest.infra.EntityConfiguration
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories");
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName(@"CategoryID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CategoryName).HasColumnName(@"CategoryName").HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("ntext").IsOptional().IsMaxLength();
            Property(x => x.Picture).HasColumnName(@"Picture").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
        }
    }
}
