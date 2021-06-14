using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int Dept_Id { get; set; }
        [Required(ErrorMessage = "Please put your name")]
        [MaxLength(20, ErrorMessage = "Max Length 20")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please put DATE OF BIRTH")]
        public string DOB { get; set; }
        [Required]
        [Range(1, 152)]
        public int Credit { get; set; }
        [Required]
        public double CGPA { get; set; }
        
    }
}