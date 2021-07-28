using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class StudentModel
    {
        public int Id { get; set; }
        public int Dept_Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public int Credit { get; set; }
        public Nullable<double> CGPA { get; set; }

        public string DepartmentntName { get; set; }
    }
}
