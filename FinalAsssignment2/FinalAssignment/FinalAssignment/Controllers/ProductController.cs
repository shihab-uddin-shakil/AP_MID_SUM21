using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalAssignment.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/Product/GetAll")]
        public List<ProductModel> GetAllProducts()
        {
            return ProductService.GetAllProducts();
        }
        [Route("api/Product/{id}")]
        public ProductModel GetProduct(int id)
        {
            return ProductService.GetProduct(id);
        }
        [Route("api/Product/Add")]
        public void AddStudent(ProductModel model)
        {
            ProductService.Addproduct(model);
        }
        [Route("api/Product/Names")]
        public List<string> GetProductNames()
        {
            return ProductService.GetProductNames();
        }
    }
}
