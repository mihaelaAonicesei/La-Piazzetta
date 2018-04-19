using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace La_Piazzetta.Models
{
    public class DIYViewModel
    {
        public List<Ingredient> Ingredients { get; set; }
        public string SelectedIngredients { get; set; }
    }
}