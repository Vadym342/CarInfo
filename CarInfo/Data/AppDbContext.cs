using CarInfo.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
           // Database.EnsureCreated();
           
        }

        public DbSet<User> users { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> shopCartItems { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDet> OrderDetail { get; set; }

    }
}
