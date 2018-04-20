using La_Piazzetta.Handlers;
using La_Piazzetta.ViewModels.Charts;
using System.Web.Mvc;

namespace La_Piazzetta.Controllers
{
    public class BAController : Controller
    {
        // GET: BA
        public ActionResult Index()
        {
            var orderData = new OrderData
            {
                ChartProductItems = BAHandler.Instance.GetTop5Items()
            };

            var productData = new OrderData
            {
                ChartProductItems = BAHandler.Instance.GetIngredients()
            };

            var model = new ChartProducts
            {
                OrderData = orderData,
                IngredientsData = productData
            };

            return View("BA", model);
        }
    }
}