using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using La_Piazzetta.Models;

namespace La_Piazzetta.Managers
{
    public class ReceiptManager
    {
        public Receipt GetById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Receipts.FirstOrDefault(r => r.Id == id);
            }
        }

        public ICollection<Receipt> GetAll()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Receipts.ToList();
            }
        }

        public Receipt GetByIdWithComments(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Receipts.Include(r => r.Comments).FirstOrDefault(r => r.Id == id);
            }
        }

        public Receipt GetByIdWithVotes(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Receipts.Include(r => r.Votes).FirstOrDefault(r => r.Id == id);
            }
        }

        public void SaveReceiptAsFavouriteForUser(int receiptId, int userId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var receipt = ctx.Receipts.FirstOrDefault(r => r.Id == receiptId);
                var person = ctx.Person.FirstOrDefault(p => p.Id == userId);

                ctx.Favourites.Add(new Favourites
                {
                    Receipt = receipt,
                    Person = person
                });
            }
        }

        public void  AddReceipt(Receipt receipt)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Receipts.Add(receipt);
                ctx.SaveChangesAsync();
            }
        }
    }
}