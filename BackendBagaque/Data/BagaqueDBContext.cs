using BackendBagaque.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendBagaque.Data
{
    public class BagaqueDBContext : DbContext
    {
        public BagaqueDBContext(DbContextOptions<BagaqueDBContext> options) : base(options) { }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductsOrders> ProductsOrders { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
