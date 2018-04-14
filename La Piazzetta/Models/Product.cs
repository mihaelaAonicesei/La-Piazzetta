using System.Collections.Generic;

namespace La_Piazzetta.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
        public virtual List<Order> Orders { get; set; }
        public bool IsCustom { get; set; }
    }
}