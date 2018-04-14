using System.Web.Http;
using La_Piazzetta.Handlers;

namespace La_Piazzetta.ApiControllers
{
    [Route("receipts")]
    public class ReceiptApiController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var model = ReceiptHandler.Instance.GetAll();
            return Ok(model);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var model = ReceiptHandler.Instance.GetById(id);
            return Ok(model);
        }

        [HttpGet]
        [Route("comments")]
        public IHttpActionResult GetCommentsByReceiptId(int id)
        {
            var model = ReceiptHandler.Instance.GetCommentsById(id);
            return Ok(model);
        }

        [HttpGet]
        [Route("votesSum")]
        public IHttpActionResult GetVotesSumByReceiptId(int id)
        {
            var model = ReceiptHandler.Instance.GetVotesSumById(id);
            return Ok(model);
        }

        [HttpPost]
        [Route("favourite")]
        public IHttpActionResult SaveFavouriteReceiptForUser(int receiptId, int userId)
        {
            ReceiptHandler.Instance.SaveFavouriteReceiptForUser(receiptId, userId);
            return Ok();
        }
    }
}