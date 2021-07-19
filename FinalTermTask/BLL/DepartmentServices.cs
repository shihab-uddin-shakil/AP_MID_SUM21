using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class DepartmentServices
    {
        public static List<string> GetDepartmentNames()
        {
            return DepartmentRepo.GetDepartmentName();
        }
        public static List<DepartmentModel> GetDepartment()
        {
            var departments=DepartmentRepo.GetDepartments();
            List<DepartmentModel> data = new List<DepartmentModel>();
            foreach(var d in departments)
            {
                var dm = new DepartmentModel() {
                    Id = d.Id,
                    Name = d.Name
                };
                data.Add(dm);
            }
            return data;
        }
        public static void AddDepartment(DepartmentModel dept)
        {
            var d = new Department()
            {
                Id = dept.Id,
                Name = dept.Name
            };
            DepartmentRepo.AddDepartment(d);
        }
    }
}
