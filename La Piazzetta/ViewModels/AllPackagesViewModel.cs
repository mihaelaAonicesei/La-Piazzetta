using System.Collections.Generic;
using La_Piazzetta.Models;

namespace La_Piazzetta.ViewModels
{
    public class AllPackagesViewModel
    {
        public ICollection<Package> Packages { get; set; }
    }
}