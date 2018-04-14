using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using La_Piazzetta.Models;

namespace La_Piazzetta.Managers
{
    public class OrderManager
    {
        public ICollection<Order> GetAll()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Order.ToList();
            }
        }

        public async Task AddOrder(Order newOrder)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Order.Add(newOrder);
                await ctx.SaveChangesAsync();
            }
        }

        public Order GetByIdIncludeProducts(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Order.Include(o => o.OrderedProducts.Select(op => op.Product)).FirstOrDefault(o => o.Id == id);
            }
        }
    }
}