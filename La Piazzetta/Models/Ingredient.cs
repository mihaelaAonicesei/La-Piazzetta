using System;
using System.Collections.Generic;

namespace La_Piazzetta.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Calories { get; set; }
        public string MeasureUnit { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual List<Receipt> Receipts { get; set; }
        public int VendorId { get; set; }
        public Vendors Vendor { get; set; }
    }
}