using System.Web.Mvc;
using La_Piazzetta.Handlers;

namespace La_Piazzetta.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var model = ProductHandler.Instance.GetAllProducts();

            return View(model);
        }
    }
}