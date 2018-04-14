using System.Collections.Generic;

namespace La_Piazzetta.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }

        public virtual List<Order> Order { get; set; }
    }
}