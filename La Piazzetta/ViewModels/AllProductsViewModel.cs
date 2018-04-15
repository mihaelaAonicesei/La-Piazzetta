using System.Collections.Generic;
using La_Piazzetta.Models;

namespace La_Piazzetta.ViewModels
{
    public class AllProductsViewModel
    {
        public ICollection<Product> Products { get; set; }
    }
}