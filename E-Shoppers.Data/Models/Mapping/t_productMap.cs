using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace E_Shoppers.Data.Models.Mapping
{
    public class t_productMap : EntityTypeConfiguration<t_product>
    {
        public t_productMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.detail)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_product", "appdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.detail).HasColumnName("detail");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.category_id).HasColumnName("category_id");
            this.Property(t => t.vendor_id).HasColumnName("vendor_id");

            // Relationships
            this.HasOptional(t => t.t_category)
                .WithMany(t => t.t_product)
                .HasForeignKey(d => d.category_id);
            this.HasOptional(t => t.t_user)
                .WithMany(t => t.t_product)
                .HasForeignKey(d => d.vendor_id);

        }
    }
}
