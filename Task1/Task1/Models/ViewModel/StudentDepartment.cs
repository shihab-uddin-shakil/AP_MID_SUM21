using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Models.ViewModel
{
    public class StudentDepartment
    {
        public Student Student { get; set; }
        public List<Department> Departments { get; set; }
        public List<Student> Students { get; set; }
        public StudentDepartment()
        {
            
            Departments = new List<Department>();
        }
    }
}