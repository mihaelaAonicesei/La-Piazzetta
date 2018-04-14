using System.Web.Http;
using La_Piazzetta.Handlers;

namespace La_Piazzetta.ApiControllers
{
    public class PackagesApiController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var model = PackagesHandler.Instance.GetAll();
            return Ok(model);
        }
    }
}