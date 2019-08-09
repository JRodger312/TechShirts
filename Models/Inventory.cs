using System;

namespace WebApplication1.Models
{
    // Inventory is configured via OnModelCreating
    public class Inventory
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public int on_hand_qty { get; set; }
        public decimal cost { get; set; }
        public decimal sale_price { get; set; }
        public int allocated_qty { get; set; }
        public int total_qty { get; set; }
    }
}
