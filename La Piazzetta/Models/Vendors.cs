using System.Collections.Generic;

namespace La_Piazzetta.Models
{
    public class Vendors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}