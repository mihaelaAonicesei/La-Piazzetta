using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using La_Piazzetta.Models;

namespace La_Piazzetta.Managers
{
    public class IngredientManager
    {
        public ICollection<Ingredient> GetAll()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Ingredients.ToList();
            }
        }

        public Ingredient GetById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Ingredients.FirstOrDefault(x => x.Id == id);
            }
        }

        public async Task AddIngredient(Ingredient ingredient)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Ingredients.Add(ingredient);
                await ctx.SaveChangesAsync();
            }
        }
    }
}