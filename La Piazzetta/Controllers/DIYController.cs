using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using La_Piazzetta.Handlers;
using La_Piazzetta.Models;

namespace La_Piazzetta.Controllers
{
    public class DIYController : Controller
    {
        public ActionResult DIY()
        {
            var model = new List<Ingredient>();
            model = IngredientHandler.Instance.GetAll().Ingredients.ToList();
            return View(model);
        }
    }
}