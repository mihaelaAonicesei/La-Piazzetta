using System.Threading.Tasks;
using La_Piazzetta.Managers;
using La_Piazzetta.Models;
using La_Piazzetta.ViewModels;

namespace La_Piazzetta.Handlers
{
    public class IngredientHandler
    {
        private static IngredientHandler instance = null;
        private static readonly object padlock = new object();
        private readonly IngredientManager ingredientManager;

        public static IngredientHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new IngredientHandler();
                    }

                    return instance;
                }
            }
        }

        public IngredientHandler()
        {
            ingredientManager = new IngredientManager();
        }

        public AllIngredientsViewModel GetAll()
        {
            var ingredients = ingredientManager.GetAll();
            return new AllIngredientsViewModel
            {
                Ingredients = ingredients
            };
        }

        public async Task AddIngredient(Ingredient ingredient)
        {
            await ingredientManager.AddIngredient(ingredient);
        }

        public Ingredient GetById(int id)
        {
            return ingredientManager.GetById(id);
        }
    }
}