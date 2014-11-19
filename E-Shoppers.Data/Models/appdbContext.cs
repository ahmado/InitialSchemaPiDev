using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using E_Shoppers.Data.Models.Mapping;

namespace E_Shoppers.Data.Models
{
    public partial class appdbContext : DbContext
    {
        static appdbContext()
        {
            Database.SetInitializer<appdbContext>(null);
        }

        public appdbContext()
            : base("Name=appdbContext")
        {
        }

        public DbSet<t_category> t_category { get; set; }
        public DbSet<t_message> t_message { get; set; }
        public DbSet<t_order> t_order { get; set; }
        public DbSet<t_order_line> t_order_line { get; set; }
        public DbSet<t_product> t_product { get; set; }
        public DbSet<t_review> t_review { get; set; }
        public DbSet<t_user> t_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new t_categoryMap());
            modelBuilder.Configurations.Add(new t_messageMap());
            modelBuilder.Configurations.Add(new t_orderMap());
            modelBuilder.Configurations.Add(new t_order_lineMap());
            modelBuilder.Configurations.Add(new t_productMap());
            modelBuilder.Configurations.Add(new t_reviewMap());
            modelBuilder.Configurations.Add(new t_userMap());
        }
    }
}
