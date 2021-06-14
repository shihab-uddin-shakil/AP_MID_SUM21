using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Task1.Models.Database
{
    public class Database
    {
        public Departments Departments { get; set; }
        public Admins Admins { get; set; }
        public Students Students { get; set; }
        public Database()
        {
            string connString = @"Server=.\sqlexpress;Database=ANet;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            Departments = new Departments(conn);
            Students = new Students(conn);
            //Admins = new Admins(conn);
        }
    }
}