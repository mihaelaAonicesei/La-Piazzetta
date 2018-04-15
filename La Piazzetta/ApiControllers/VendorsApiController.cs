using System.Threading.Tasks;
using System.Web.Http;
using La_Piazzetta.Handlers;
using La_Piazzetta.Models;

namespace La_Piazzetta.ApiControllers
{
    public class VendorsApiController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> Add(Vendors newVendor)
        {
            await VendorHandler.Instance.Add(newVendor);
            return Ok();
        }
    }
}