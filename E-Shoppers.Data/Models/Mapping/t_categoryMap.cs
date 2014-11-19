using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace E_Shoppers.Data.Models.Mapping
{
    public class t_categoryMap : EntityTypeConfiguration<t_category>
    {
        public t_categoryMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_category", "appdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
