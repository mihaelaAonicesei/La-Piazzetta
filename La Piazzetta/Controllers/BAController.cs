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
            var temp = new OrderChartData
            {
                //Items = new List<ChartProductItem>{
                //    new ChartProductItem
                //    {
                //        Name = "v1"
                //    },
                //    new ChartProductItem
                //    {
                //        Name = "v2"
                //    }
                //}
                Items = BAHandler.Instance.GetTop5Items()
            };

            var model = new ChartProducts
            {
                OrderData = temp
            };

            return View("BA", model);
        }
    }
}