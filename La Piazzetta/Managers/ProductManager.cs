using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using La_Piazzetta.Models;

namespace La_Piazzetta.Managers
{
    public class ProductManager
    {
        public ICollection<Product> GetAll()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Products.ToList();
            }
        }

        public async Task AddProduct(Product newProduct)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Products.Add(newProduct);
                await ctx.SaveChangesAsync();
            }
        }
    }
}