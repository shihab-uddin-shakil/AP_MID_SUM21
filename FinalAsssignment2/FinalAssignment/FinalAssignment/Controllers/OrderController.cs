using BEL;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalAssignment.Controllers
{
    public class OrderController : ApiController
    {
        [Route("api/Order/GetAll")]
        public List<OrderModel> GetAllProducts()
        {
            return OrderService.GetBProduct();
        }
        [Route("api/Order/{id}")]
        public Buy_Products GetProduct(int id)
        {
            return OrderService.GetSOrder(id);
        }
        [Route("api/Order/Add")]
        public void AddOrder(OrderModel model)
        {
            OrderService.AddOrder(model);
        }
        [Route("api/Order/Detail/{id}")]
        public void Deatil(int id)
        {
            OrderService.GetSOrder(id);
        }
    }
}
