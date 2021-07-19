﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace FinalTermTask.Controllers
{
    public class DepartmentController : ApiController
    {
        [Route("api/Department/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return DepartmentServices.GetDepartmentNames();
        }
        [Route("api/Department/GetAll")]
        [HttpGet]
        public List<DepartmentModel> GetAllDepartment()
        {
            return DepartmentServices.GetDepartment();
        }
        [Route("api/Department/Add")]
        [HttpPost]
        public void Add(DepartmentModel dept)
        {
            DepartmentServices.AddDepartment(dept);
        }

    }
}