using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Please fillup your username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please put your password")]
        public string Password { get; set; }
    }
}