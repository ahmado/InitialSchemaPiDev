using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace E_Shoppers.Data.Models.Mapping
{
    public class t_orderMap : EntityTypeConfiguration<t_order>
    {
        public t_orderMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("t_order", "appdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.order_date).HasColumnName("order_date");
            this.Property(t => t.customer_fk).HasColumnName("customer_fk");

            // Relationships
            this.HasMany(t => t.t_order_line)
                .WithMany(t => t.t_order)
                .Map(m =>
                    {
                        m.ToTable("t_order_order_line", "appdb");
                        m.MapLeftKey("order_fk");
                        m.MapRightKey("order_line_fk");
                    });

            this.HasRequired(t => t.t_user)
                .WithMany(t => t.t_order)
                .HasForeignKey(d => d.customer_fk);

        }
    }
}
