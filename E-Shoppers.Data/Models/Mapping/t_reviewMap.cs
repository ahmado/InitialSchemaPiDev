using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace E_Shoppers.Data.Models.Mapping
{
    public class t_reviewMap : EntityTypeConfiguration<t_review>
    {
        public t_reviewMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.text)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_review", "appdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.text).HasColumnName("text");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.customer_id).HasColumnName("customer_id");
            this.Property(t => t.product_fk).HasColumnName("product_fk");

            // Relationships
            this.HasOptional(t => t.t_product)
                .WithMany(t => t.t_review)
                .HasForeignKey(d => d.product_fk);
            this.HasOptional(t => t.t_user)
                .WithMany(t => t.t_review)
                .HasForeignKey(d => d.customer_id);

        }
    }
}
