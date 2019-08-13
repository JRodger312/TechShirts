using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Inventory> Inventory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // these two set the types for the decimal entity types for cost and sale_price
            modelBuilder.Entity<Inventory>()
                .Property(p => p.cost)
                .HasColumnType("decimal(16,4)");
            modelBuilder.Entity<Inventory>()
                .Property(p => p.sale_price)
                .HasColumnType("decimal(16,4)");

            // Seed database
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory
                {
                    id = 121,
                    name = "Blue Tech",
                    description = "Blue T-Shirt",
                    size = "M",
                    color = "blue",
                    on_hand_qty = 44,
                    cost = 2.50m,
                    sale_price = 8.99m,
                    allocated_qty = 9,
                    total_qty = 80
                },
                new Inventory
                {
                    id = 100,
                    name = "Black Tech",
                    description = "Black T-Shirt",
                    size = "XL",
                    color = "violet",
                    on_hand_qty = 24,
                    cost = 2.99m,
                    sale_price =4.99m,
                    allocated_qty = 5,
                    total_qty = 32
                }
            );
        }
    }
}
