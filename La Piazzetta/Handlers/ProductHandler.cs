using System.Threading.Tasks;
using La_Piazzetta.Managers;
using La_Piazzetta.Models;
using La_Piazzetta.ViewModels;

namespace La_Piazzetta.Handlers
{
    public class ProductHandler
    {
        private static ProductHandler instance;
        private static readonly object padlock = new object();
        private readonly ProductManager productManager;

        public static ProductHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null) instance = new ProductHandler();

                    return instance;
                }
            }
        }

        public ProductHandler()
        {
            productManager = new ProductManager();
        }

        public AllProductsViewModel GetAllProducts()
        {
            var products = productManager.GetAll();
            return new AllProductsViewModel
            {
                Products = products
            };
        }

        public async Task AddProduct(Product newProduct)
        {
            await productManager.AddProduct(newProduct);
        }
    }
}