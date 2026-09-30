using System;
using System.Collections.Generic;
using System.Text;

namespace adv_2
{
    internal class ProductHelper
    {
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> search)
        {
            List<Product> result = new List<Product>();

            foreach (Product product in products)
            {
                if (search(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
        public static void PrintList(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name} - ${product.Price} (Stock : {product.Stock})");
            }
        }
        public static void LowStock(List<Product> products)
        {
            foreach (Product p in products)
            {
                Console.WriteLine($"[LOW STOCK] {p.Name} : only {p.Stock} left");
            }
        }
    }
}
