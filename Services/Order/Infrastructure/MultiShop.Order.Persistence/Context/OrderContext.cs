using Microsoft.EntityFrameworkCore;
using MultiShot.Order.Applicatinon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Persistence.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1440;Database=MultiShopOrderDb;User Id=sa;Password=Kagan19071q.;Encrypt=False");
            //Server=localhost,1440;initial Catalog=MultiShopOrderDb;User=sa;Password=Kagan19071q.
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Ordering> Orderings { get; set; }
    }
}
