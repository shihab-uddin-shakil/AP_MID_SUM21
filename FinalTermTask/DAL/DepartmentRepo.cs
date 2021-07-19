using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentRepo
    {
        static ANetEntities context;
        static DepartmentRepo()
        {
            context = new ANetEntities();
        }
        public static List<string> GetDepartmentName()
        {
            var data = context.Departments.Select(e => e.Name).ToList();
            return data;
        }
        public static List<Department> GetDepartments()
        {
            
            return context.Departments.ToList();
        }
        public static void AddDepartment( Department d)
        {
            context.Departments.Add(d);
            context.SaveChanges();
        }
    }
}
