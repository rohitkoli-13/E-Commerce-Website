using Microsoft.EntityFrameworkCore;
using OnlineShoppingManagement.Entities;

namespace OnlineShopPingManagement.Entities
{
    public class ProjectDbContext:DbContext
    {
        private IConfiguration _configuration;

        public ProjectDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Admin>? Admins { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<YourOrders>? YourOrders { get; set; }
        public DbSet<Favourite>? Favourites { get; set; }
        public DbSet<Payment> payments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configure connection string
            //optionsBuilder.UseSqlServer("Data Source=TRI03L-PW07B2DE\\SQLEXPRESS;Initial Catalog=PracticeOnlineShoppingDb;User ID=sa;password=Passw0rd;TrustServerCertificate=True");
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DbConnection"));
        }
    }
}
