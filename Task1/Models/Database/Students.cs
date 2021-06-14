using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Task1.Models.Database
{
    public class Students
    {
        SqlConnection conn;

        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Student s)
        {
            //string query = String.Format("Insert into Products values ('{0}','{1}',{2},{3})", p.Name, p.Description, p.Price, p.Qty);
            string query = "Insert into Student values(@Dept_Id,@name,@dob,@credit,@cgpa)";
            SqlCommand cmd = new SqlCommand(query, conn);
           
            cmd.Parameters.AddWithValue("@Dept_id", s.Dept_Id);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@dob", s.DOB);
            cmd.Parameters.AddWithValue("@credit", s.Credit);
            cmd.Parameters.AddWithValue("@cgpa", s.CGPA);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            string query = "select * from Student";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Dept_Id = reader.GetInt32(reader.GetOrdinal("Dept_Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    DOB = reader.GetString(reader.GetOrdinal("DOB")),
                     Credit= reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                   
                };
                students.Add(s);
            }
            conn.Close();
            return students;
        }
        public Student Get(int id)
        {
            Student s = null;
            string query = $"select * from Student Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Dept_Id = reader.GetInt32(reader.GetOrdinal("Dept_Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    DOB = reader.GetString(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                };
            }
            conn.Close();
            return s;
        }
        public void Update(Student p)
        {
            string query = $"Update Student Set Name='{p.Name}',DOB={p.DOB}, Credit={p.Credit}, CGPA='{p.CGPA}' Where Id = {p.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int id)
        {
            string query = $"DELETE FROM Student Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}