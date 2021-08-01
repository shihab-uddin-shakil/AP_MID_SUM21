using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ProductService
    {
        public static void Addproduct(ProductModel product)
        {
            var data = AutoMapper.Mapper.Map<ProductModel, Product>(product);
            ProductRepo.AddProduct(data);
        }
        public static ProductModel GetProduct(int id)
        {
            var data = ProductRepo.GetProduct(id);
            var p = AutoMapper.Mapper.Map<Product, ProductModel>(data);
            return p;
        }
        public static List<ProductModel> GetAllProducts()
        {
            var data = ProductRepo.GetAllProduct();
            var p = AutoMapper.Mapper.Map<List<Product>, List<ProductModel>>(data);
            return p;
        }

        public static List<string> GetProductNames()
        {
            var data = ProductRepo.GetProductNames();
            return data;
        }
    }
}
