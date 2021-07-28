using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<Department, DepartmentModel>();
            CreateMap<Department, DepartmentDetail>();
            CreateMap<Student,StudentModel>();

        }
    }
}
