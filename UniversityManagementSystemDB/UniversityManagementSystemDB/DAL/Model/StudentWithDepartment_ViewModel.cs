using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemDB.DAL.Model
{
    public class StudentWithDepartment_ViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string Code { get; set; }
    }
}