using System.Collections.Generic;
using La_Piazzetta.Models;

namespace La_Piazzetta.ViewModels
{
    public class AllVendorsViewModel
    {
        public ICollection<Vendors> Vendors { get; set; }
    }
}