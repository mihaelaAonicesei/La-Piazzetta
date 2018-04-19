using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using La_Piazzetta.Handlers;
using La_Piazzetta.Models;

namespace La_Piazzetta.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var model = new ProductsPageModel();
            model.Products = ProductHandler.Instance.GetAllProducts().Products.ToList();

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(Product product)
        {
            await ProductHandler.Instance.AddProduct(product);
            var model = new ProductsPageModel();
            model.Products = ProductHandler.Instance.GetAllProducts().Products.ToList();
            model.Product = null;
            return View("Index",model);
        }
    }
}