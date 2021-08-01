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
    public class CategoryController : ApiController
    {
        [Route("api/Category/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return CategoryService.GetCategoryName();
        }
        
        [Route("api/Category/GetAll")]
        [HttpGet]
        public List<CategoryModel> GetAllDepartments()
        {
            return CategoryService.GetCategory();
        }
       
        [Route("api/Category/Add")]
        [HttpPost]
        public void Add(CategoryModel c)
        {
            CategoryService.AddCategory(c);
        }
        
       [Route("api/Category/All/Details")]
       public List<CategoryDetail> GetCategoryWithDetails()
       {
           return CategoryService.GetCategoryWithDetails();
       }
       [Route("api/Category/{id}/Details")]
       public CategoryDetail GetCategoryDetail(int id)
       {
           return CategoryService.GetCategoryDetail(id);
       }

    }
}
