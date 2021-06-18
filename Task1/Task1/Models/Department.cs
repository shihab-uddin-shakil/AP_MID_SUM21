using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class Department
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public List<Student> Students { get; set; }
      //  public List<Department> Departments { get; internal set; }
      //  public Student Student { get; internal set; }
    }
}