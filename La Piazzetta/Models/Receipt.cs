using System;
using System.Collections.Generic;

namespace La_Piazzetta.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Vote> Votes { get; set; }
    }
}