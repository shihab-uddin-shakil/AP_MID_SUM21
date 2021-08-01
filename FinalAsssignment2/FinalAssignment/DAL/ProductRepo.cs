using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static MFCSEntities context;
        static ProductRepo()
        {
            context = new MFCSEntities();
        }

        public static void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public static List<Product> GetAllProduct()
        {
            var data = context.Products.ToList();
            return data;
        }
        public static Product GetProduct(int id)
        {
            var data = context.Products.FirstOrDefault(e => e.Id == id);
            return data;
        }
        public static List<string> GetProductNames()
        {
            var data = context.Products.Select(e => e.Name).ToList();
            return data;
        }
    }
}
