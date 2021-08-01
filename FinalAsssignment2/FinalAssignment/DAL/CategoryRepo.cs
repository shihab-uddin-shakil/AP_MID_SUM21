using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class CategoryRepo
    {
        static MFCSEntities context;
        static CategoryRepo()
        {
            context = new MFCSEntities();
        }
        public static List<string> GetCategoryNames()
        {
            var data = context.Product_Type.Select(e => e.Title).ToList();
            return data;
        }

        public static List<Product_Type> GetCategorys()
        {
            return context.Product_Type.ToList();
        }
        public static void AddCgory(Product_Type c)
        {
            context.Product_Type.Add(c);
            context.SaveChanges();
        }

        public static Product_Type GetCategoryDetail(int id)
        {
            return context.Product_Type.FirstOrDefault(e => e.Id == id);
        }
    }
}
