using La_Piazzetta.Models;
using La_Piazzetta.ViewModels.Charts;
using System.Collections.Generic;
using System.Linq;

namespace La_Piazzetta.Managers
{
    public class BAManager
    {
        public IEnumerable<ChartProductItem> GetTop5Items()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var top5Products = ctx.OrderedProducts
                    .OrderByDescending(op => op.Quantity)
                    .Take(5)
                    .Select(op => new { ProductId = op.ProductId, Quantity = op.Quantity });

                foreach(var prod in top5Products)
                {
                    yield return new ChartProductItem
                    {
                        Name = ctx.Products.Find(prod.ProductId).Name,
                        Value = prod.Quantity
                    };
                }
            }
        }
    }
}