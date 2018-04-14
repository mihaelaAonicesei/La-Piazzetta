using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace La_Piazzetta.Models
{
    public class OrderedProducts
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

    }
}