using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystemDB.DAL.Gateway;
using UniversityManagementSystemDB.DAL.Model;

namespace UniversityManagementSystemDB.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway departmentGateway = new DepartmentGateway();
        public List<Department> GetAllDepartment()
        {
            return departmentGateway.GetAllDepartment();
        } 
    }
}