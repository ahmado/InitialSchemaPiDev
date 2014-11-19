using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace E_Shoppers.Data.Models.Mapping
{
    public class t_userMap : EntityTypeConfiguration<t_user>
    {
        public t_userMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DTYPE)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.type)
                .HasMaxLength(255);

            this.Property(t => t.username)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("t_user", "appdb");
            this.Property(t => t.DTYPE).HasColumnName("DTYPE");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.registerdate).HasColumnName("registerdate");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.rate).HasColumnName("rate");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.solde).HasColumnName("solde");
        }
    }
}
