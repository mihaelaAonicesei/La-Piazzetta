using System.Collections.Generic;

namespace La_Piazzetta.Models
{
    public class Vendors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
    }
}