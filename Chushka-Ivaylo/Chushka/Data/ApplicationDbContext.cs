using Chushka.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Chushka.Data
{
    public class ApplicationDbContext : IdentityDbContext<Client,ApplicationRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }
            public DbSet< Client> Clients{ get; set; }
            public DbSet<Order> Orders{ get; set; }
            public DbSet<Product> Products{ get; set; }
            public DbSet<ProductOrder> ProductOrders{ get; set; }
    }
}