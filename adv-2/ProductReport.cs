using System;
using System.Collections.Generic;
using System.Text;

namespace adv_2
{
    internal class ProductReport
    {
        public static void PrintReport(List<Product> products, Action<Product> action)
        {
            foreach (Product product in products)
            {
                action(product);
            }
        }
        public static List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
        {
            List<string> result = new List<string>();
            foreach (Product product in products)
            {
                result.Add(transform(product));
            }
            return result;
        }
        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> filter)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in products)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
}
