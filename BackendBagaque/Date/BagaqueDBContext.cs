using BackendBagaque.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BackendBagaque.Date
{
    public class BagaqueDBContext : DbContext
    {
        public BagaqueDBContext(DbContextOptions<BagaqueDBContext> options) : base(options) { }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }
        public DbSet<Users> Users { get; set; }

    }

}
