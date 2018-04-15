using System.Threading.Tasks;
using System.Web.Http;
using La_Piazzetta.Handlers;
using La_Piazzetta.Models;

namespace La_Piazzetta.ApiControllers
{
    [Route("products")]
    public class ProductsApiController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> AddProduct(Product newProduct)
        {
            await ProductHandler.Instance.AddProduct(newProduct);

            return Ok();
        }
    }
}