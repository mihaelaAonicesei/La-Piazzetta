using System.Linq;
using La_Piazzetta.Managers;
using La_Piazzetta.Models;
using La_Piazzetta.ViewModels;

namespace La_Piazzetta.Handlers
{
    public class ReceiptHandler
    {
        private static ReceiptHandler instance = null;
        private static readonly object padlock = new object();
        private readonly ReceiptManager receiptManager;

        public static ReceiptHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ReceiptHandler();
                    }

                    return instance;
                }
            }
        }

        public ReceiptHandler()
        {
            receiptManager = new ReceiptManager();
        }

        public Receipt GetById(int id)
        {
            return receiptManager.GetById(id);
        }

        public AllReceiptsViewModel GetAll()
        {
            var receipts = receiptManager.GetAll();
            return new AllReceiptsViewModel
            {
                Receipts = receipts
            };
        }

        public AllReceiptCommentsViewModel GetCommentsById(int id)
        {
            var receipt = receiptManager.GetByIdWithComments(id);
            return new AllReceiptCommentsViewModel
            {
                Comments = receipt.Comments
            };
        }

        public double GetVotesSumById(int id)
        {
            var receipt = receiptManager.GetByIdWithVotes(id);
            return receipt.Votes.Average(v => v.Rating);
        }

        public void SaveFavouriteReceiptForUser(int receiptId, int userId)
        {
            receiptManager.SaveReceiptAsFavouriteForUser(receiptId, userId);
        }
    }
}