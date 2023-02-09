using NathansStuff.Models;
using Microsoft.EntityFrameworkCore;

namespace NathansStuff.Data
{
    public class NathansStuffContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderLine> OrderLines { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        public NathansStuffContext(DbContextOptions<NathansStuffContext> options) : base(options) { }
    }
}
