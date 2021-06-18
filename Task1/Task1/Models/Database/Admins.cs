using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Task1.Models.Database
{
    public class Admins
    {
        

        public Admins()
        {
        }
        public bool loginValidate(string username,string password)
        {
            //Admin a = null;
            string connString = @"Server=.\sqlexpress;Database=ANet;Integrated Security=true;";
            SqlConnection conn1 = new SqlConnection(connString);
            string query = $"select * from Admins Where UserName={username} and Password={password}";
            SqlCommand cmd = new SqlCommand(query, conn1);
            conn1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                /*  a = new Admin()
                  {
                      Id = reader.GetInt32(reader.GetOrdinal("Id")),
                      Name = reader.GetString(reader.GetOrdinal("Name")),
                      UserName = reader.GetString(reader.GetOrdinal("UserName")),
                      Password = reader.GetString(reader.GetOrdinal("Password")),
                  };?*/
                //conn1.Close();
                return true;
            }
            conn1.Close();
            return false;
        }
    }
}