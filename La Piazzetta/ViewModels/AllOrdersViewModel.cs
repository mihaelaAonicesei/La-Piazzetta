using System.Collections.Generic;
using La_Piazzetta.Models;

namespace La_Piazzetta.ViewModels
{
    public class AllOrdersViewModel
    {
        public ICollection<Order> Orders { get; set; }
    }
}