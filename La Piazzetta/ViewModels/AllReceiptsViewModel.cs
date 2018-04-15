using System.Collections.Generic;
using La_Piazzetta.Models;

namespace La_Piazzetta.ViewModels
{
    public class AllReceiptsViewModel
    {
        public ICollection<Receipt> Receipts { get; set; }
    }
}