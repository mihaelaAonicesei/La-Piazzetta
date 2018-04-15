using System.Collections.Generic;
using System.Linq;
using La_Piazzetta.Models;

namespace La_Piazzetta.Managers
{
    public class PackagesManager
    {
        public ICollection<Package> GetAll()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Packages.ToList();
            }
        }
    }
}