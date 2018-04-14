using System;
using System.Collections.Generic;

namespace La_Piazzetta.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual List<OrderedProducts> OrderedProducts { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int PackageId { get; set; }
        public virtual Package Package { get; set; }
        public int FidelityPoints { get; set; }
    }
}