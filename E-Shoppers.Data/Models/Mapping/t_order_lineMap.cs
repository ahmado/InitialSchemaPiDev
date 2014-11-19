using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace E_Shoppers.Data.Models.Mapping
{
    public class t_order_lineMap : EntityTypeConfiguration<t_order_line>
    {
        public t_order_lineMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("t_order_line", "appdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.item_fk).HasColumnName("item_fk");

            // Relationships
            this.HasRequired(t => t.t_product)
                .WithMany(t => t.t_order_line)
                .HasForeignKey(d => d.item_fk);

        }
    }
}
