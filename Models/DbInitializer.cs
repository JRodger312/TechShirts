using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Data;
namespace WebApplication1.Models
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // context.Database.EnsureCreated();

            // Look for any Inventory.
            if (context.Inventory.Any())
            {
            return;   // DB has been seeded
            }

            context.Inventory.AddRange(
                    new Inventory
                    {
                        name = "Black Tech",
                        description = "Black T-Shirt",
                        size = "XL",
                        color = "violet",
                        on_hand_qty = 24,
                        cost = 2.99m,
                        sale_price =4.99m,
                        allocated_qty = 5,
                        total_qty = 32
                    },

                    new Inventory
                    {
                        name = "Red Tech",
                        description = "Red T-Shirt",
                        size = "S",
                        color = "red",
                        on_hand_qty = 2,
                        cost = 1.99m,
                        sale_price =3.99m,
                        allocated_qty = 2,
                        total_qty = 10
                    },

                    new Inventory
                    {
                        name = "Blue Tech",
                        description = "Blue T-Shirt",
                        size = "M",
                        color = "blue",
                        on_hand_qty = 44,
                        cost = 2.50m,
                        sale_price = 8.99m,
                        allocated_qty = 9,
                        total_qty = 80
                    }
                );
            context.SaveChanges();
        }
    }
}
