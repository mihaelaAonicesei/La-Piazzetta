using La_Piazzetta.Handlers;
using System.Web.Mvc;

namespace La_Piazzetta.Controllers
{
    public class ReportsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeesReport()
        {
            return View(EmployeeHandler.Instance.GetAll());
        }

        public ActionResult VendorsReport()
        {
            return View(VendorHandler.Instance.GetAll());
        }

        public ActionResult StockReport()
        {
            return View(IngredientHandler.Instance.GetAll());
        }

        public ActionResult SalesReport()
        {
            return View(IngredientHandler.Instance.GetAll());
        }
    }
}