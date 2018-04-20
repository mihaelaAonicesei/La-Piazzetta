using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using La_Piazzetta.Models;

namespace La_Piazzetta.Managers
{
    public class VendorManager
    {
        public ICollection<Vendors> GetAll()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Vendors.Include("Ingredients").ToList();
            }
        }

        public async Task Add(Vendors newVendor)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Vendors.Add(newVendor);
                await ctx.SaveChangesAsync();
            }
        }
    }
}