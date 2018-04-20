using La_Piazzetta.Models;
using La_Piazzetta.ViewModels.Charts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace La_Piazzetta.Managers
{
    public class BAManager
    {
        public IEnumerable<ChartProductItem> GetTop5Items()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var top5Products = ctx.OrderedProducts
                    .OrderByDescending(op => op.Quantity)
                    .Take(5)
                    .Select(op => new { ProductId = op.ProductId, Quantity = op.Quantity })
                    .ToList();

                var outputList = new List<ChartProductItem>();
                foreach (var prod in top5Products)
                {
                    outputList.Add(new ChartProductItem
                    {
                        Name = ctx.Products.First<Product>(p => p.Id == prod.ProductId).Name,
                        Value = prod.Quantity
                    });
                }

                return outputList;
            }
        }

        public ICollection<ChartProductItem> GetIngredients()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var productsWithIngredients = ctx.Ingredients
                    .Where(p => true)
                    .Include(i => i.Products)
                   .OrderByDescending(i => i.Products.Count)
                   .ToList();

                var outputList = new List<ChartProductItem>();
                foreach (var ingr in productsWithIngredients)
                {
                    outputList.Add(new ChartProductItem
                    {
                        Name = ctx.Ingredients.First<Ingredient>(p => p.Id == ingr.Id).Name,
                        Value = ingr.Products.Count
                    });
                }

                return outputList;
            }
        }
    }
}