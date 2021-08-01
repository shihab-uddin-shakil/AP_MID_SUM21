using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL.MapperConfig
{
  public  class AutoMapperSettings :Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<CategoryModel, Product_Type>().ForMember(e => e.Products, d => d.Ignore());
             CreateMap<Product_Type, CategoryDetail>();

          CreateMap<ProductModel,Product >().ForMember(e => e.Product_Type, sm => sm.Ignore());
        

        }
    }
}
