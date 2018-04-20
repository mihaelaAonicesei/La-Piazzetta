using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using La_Piazzetta.Handlers;
using La_Piazzetta.Models;

namespace La_Piazzetta.Controllers
{
    public class DIYController : Controller
    {
        public ActionResult DIY()
        {
            var model = new DIYViewModel();
            model.Ingredients = IngredientHandler.Instance.GetAll().ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult PlaceOrder(DIYViewModel selectedIngr)
        {
            var allIngredients = selectedIngr.SelectedIngredients.Split(',')
                .Distinct().Where(x => !string.IsNullOrEmpty(x)).ToArray();
            var all = new List<Ingredient>();
            var total = 0;
            foreach (var ing in allIngredients)
            {
                var i = IngredientHandler.Instance.GetById(int.Parse(ing));
                all.Add(i);
                total += i.Price;
            }

            var favReceipt = new Receipt()
            {
                Name = "Custom receipt",
                PublishedDate = DateTime.Now,
                Ingredients = all
            };

            ViewBag.total = total;
            ViewBag.finaltotal = total + 2;
            ReceiptHandler.Instance.AddReceipt(favReceipt);
            return View();
        }
    }
}