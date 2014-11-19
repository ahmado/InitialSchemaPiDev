using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace E_Shoppers.Data.Models.Mapping
{
    public class t_messageMap : EntityTypeConfiguration<t_message>
    {
        public t_messageMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.subject)
                .HasMaxLength(255);

            this.Property(t => t.text)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_message", "appdb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.text).HasColumnName("text");
            this.Property(t => t.customer_id).HasColumnName("customer_id");

            // Relationships
            this.HasOptional(t => t.t_user)
                .WithMany(t => t.t_message)
                .HasForeignKey(d => d.customer_id);

        }
    }
}
