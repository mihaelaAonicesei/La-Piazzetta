using System.Collections.Generic;
using La_Piazzetta.Models;

namespace La_Piazzetta.ViewModels
{
    public class AllReceiptCommentsViewModel
    {
        public ICollection<Comment> Comments { get; set; }
    }
}