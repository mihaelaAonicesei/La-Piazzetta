using System.Linq;
using System.Threading.Tasks;
using La_Piazzetta.Managers;
using La_Piazzetta.Models;
using La_Piazzetta.ViewModels;

namespace La_Piazzetta.Handlers
{
    public class OrderHandler
    {
        private static OrderHandler instance = null;
        private static readonly object padlock = new object();
        private readonly OrderManager orderManager;

        public static OrderHandler Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new OrderHandler();
                    }

                    return instance;
                }
            }
        }

        public OrderHandler()
        {
            orderManager = new OrderManager();
        }

        public AllOrdersViewModel GetAllOrders()
        {
            var orders = orderManager.GetAll();
            return new AllOrdersViewModel
            {
                Orders = orders
            };
        }

        public int GetTotalAmountForOrder(int id)
        {
            var order = orderManager.GetByIdIncludeProducts(id);
            if (order == null)
            {
                return -1;
            }

            var sum = 0;
            foreach (var orderedProduct in order.OrderedProducts)
            {
                sum += orderedProduct.Quantity * orderedProduct.Product.Price;
            }

            return sum;
        }

        public async Task AddOrder(Order newOrder)
        {
            await orderManager.AddOrder(newOrder);
        }
    }
}