using System.Threading.Tasks;
using System.Web.Http;
using La_Piazzetta.Handlers;
using La_Piazzetta.Models;

namespace La_Piazzetta.ApiControllers
{
    [Route("orders")]
    public class OrderApiController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> AddOrder(Order newOrder)
        {
            await OrderHandler.Instance.AddOrder(newOrder);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var model = OrderHandler.Instance.GetAllOrders();
            return Ok(model);
        }

        [HttpGet]
        [Route("totalAmount")]
        public IHttpActionResult GetTotalForOrder(int orderId)
        {
            var amount = OrderHandler.Instance.GetTotalAmountForOrder(orderId);
            return Ok(amount);
        }
    }
}