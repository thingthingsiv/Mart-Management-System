using System;

namespace Mart_Management_System
{
    public class Product
    {
        public int Id { get; set; }
        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        public DateTime DateInsert { get; set; }
    }
}
