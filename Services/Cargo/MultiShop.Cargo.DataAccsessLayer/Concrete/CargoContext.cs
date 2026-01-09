using Microsoft.EntityFrameworkCore;
using Multihop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccsessLayer.Concrete
{
    public class CargoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1441;Initial Catalog=MultiShopCargoDb;User=sa;Password=Kagan19071q.");
        }

        public DbSet<CargoCompany> CargoCompany { get; set; }

        public DbSet<CargoDetail> CargoDetail { get; set; }
        public DbSet<CargoCustomer> CargoCustomer { get; set; }
        public DbSet<CargoOperation> CargoOperation { get; set; }
    }
}
