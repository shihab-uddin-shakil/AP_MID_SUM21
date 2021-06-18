using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Task1.Models.Database
{
    public class Departments
    {
        SqlConnection conn;

        public Departments(SqlConnection conn)
        {
            this.conn = conn;
        }
        public List<Department> GetAll()
        {
            List<Department> departments = new List<Department>();
            string query = "select * from Departments";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Department d = new Department()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    
                };
                departments.Add(d);
            }
            conn.Close();
            return departments;
        }
    }
}