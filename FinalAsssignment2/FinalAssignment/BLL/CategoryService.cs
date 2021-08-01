using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class CategoryService
    {
        public static List<string> GetCategoryName()
        {
            return CategoryRepo.GetCategoryNames();
        }
        public static List<CategoryModel> GetCategory()
        {
            var departments = CategoryRepo.GetCategorys();
            var data = AutoMapper.Mapper.Map<List<Product_Type>, List<CategoryModel>>(departments);

            return data;
        }
        public static void AddCategory(CategoryModel c)
        {
            var d = AutoMapper.Mapper.Map<CategoryModel, Product_Type>(c);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            CategoryRepo.AddCgory(d);
        }
        

        public static CategoryDetail GetCategoryDetail(int id)
        {
            var d = CategoryRepo.GetCategoryDetail(id);
            var cdetail = AutoMapper.Mapper.Map<Product_Type, CategoryDetail>(d);
            return cdetail;
        }

        public static List<CategoryDetail> GetCategoryWithDetails()
        {
            var data = CategoryRepo.GetCategorys();
            var cDetails = AutoMapper.Mapper.Map<List<Product_Type>, List<CategoryDetail>>(data);
            return cDetails;

        }

    }
}
