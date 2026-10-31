using Microsoft.EntityFrameworkCore;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiShop.Order.Persistence.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;initial Catalog=MultiShopOrderDb;integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Ordering> Orderings { get; set; }

    }
}
