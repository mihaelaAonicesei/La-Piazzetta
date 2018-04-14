using System.Threading.Tasks;
using System.Web.Http;
using La_Piazzetta.Handlers;
using La_Piazzetta.Models;

namespace La_Piazzetta.ApiControllers
{
    [Route("ingredients")]
    public class IngredientsApiController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var model = IngredientHandler.Instance.GetAll();
            return Ok(model);
        }

        [HttpPost]
        public async Task<IHttpActionResult> Add(Ingredient ingredient)
        {
            await IngredientHandler.Instance.AddIngredient(ingredient);
            return Ok();
        }
    }
}