using System.Web.Mvc;
using La_Piazzetta.Handlers;

namespace La_Piazzetta.Controllers
{
    public class VendorController : Controller
    {
        public ActionResult Index()
        {
            var model = VendorHandler.Instance.GetAll();
            return View(model);
        }
    }
}