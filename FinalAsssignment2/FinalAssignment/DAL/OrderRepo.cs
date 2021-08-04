using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class OrderRepo
    {
    static MFCSEntities context;
        static OrderRepo()
        {
            context = new MFCSEntities();
        }

        public static void AddBuyProduct(Buy_Products buy_Products)
        {
            context.Buy_Products.Add(buy_Products);
            context.SaveChanges();
        }
        public static List<Buy_Products> GetAllBuyProduct()
        {
            var data = context.Buy_Products.ToList();
            return data;
        }
        public static Buy_Products GetBuyProduct(int id)
        {
            var data = context.Buy_Products.FirstOrDefault(e => e.Id == id);
            return data;
        }
        public static Buy_Products GetBuyProductDetail(int id)
        {
            var data = context.Buy_Products.FirstOrDefault(e => e.User_Id == id);
            return data;
        }
       /// public static Buy_Products GetBuyOrderAmount(int id)
        //{
          //  var data = context.Buy_Products.ToList().Where(e => e.User_Id == id).Sum(e=>e.Price);
           //return data;
       // }
    }
}
