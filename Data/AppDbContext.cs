using Microsoft.EntityFrameworkCore;
using ShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        DbSet<Address> Addresses { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<DeliveryNote> DeliveryNotes { get; set; }
        DbSet<Invoice> Invoices { get; set; }
        DbSet<Item> Items { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Position> Positions { get; set; }

    }
}
