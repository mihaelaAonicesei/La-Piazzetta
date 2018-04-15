using System.Web.Mvc;
using La_Piazzetta.Handlers;

namespace La_Piazzetta.Controllers
{
    public class OrderController : Controller
    {
        // GET all
        public ActionResult Index()
        {
            ViewBag.Message = "Orders.";

            var model = OrderHandler.Instance.GetAllOrders();

            return View(model);
        }
    }
}