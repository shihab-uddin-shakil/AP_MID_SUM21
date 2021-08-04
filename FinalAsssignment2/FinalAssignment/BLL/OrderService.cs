using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderService
    {
        public static List<OrderModel> GetBProduct()
        {
            var p = OrderRepo.GetAllBuyProduct();
            List<OrderModel> data = new List<OrderModel>();
            foreach (var d in p)
            {
                var dm = new OrderModel()
                {
                    Id = d.Id,
                    Type = d.Type,
                    Name = d.Name,
                    Quantity = (int)d.Quantity,
                    Price = (int)d.Price,
                    User_Id = (int)d.User_Id,
                    Date= d.Date

                   
                   
                };
                data.Add(dm);
            }
            return data;
        }
        public static void AddOrder(OrderModel d)
        {
            var o = new Buy_Products()
            {
                Id = d.Id,
                Type = d.Type,
                Name = d.Name,
                Quantity = d.Quantity,
                Price = d.Price,
                User_Id =d.User_Id,
                Date = d.Date
            };
            OrderRepo.AddBuyProduct(o);
        }
        public static Buy_Products GetSOrder(int id)
        {
            var data = OrderRepo.GetBuyProductDetail(id);
            return data;
        }
    }
}
