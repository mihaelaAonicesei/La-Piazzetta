using System.Collections.Generic;
using La_Piazzetta.Models;

namespace La_Piazzetta.ViewModels
{
    public class AllIngredientsViewModel
    {
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}