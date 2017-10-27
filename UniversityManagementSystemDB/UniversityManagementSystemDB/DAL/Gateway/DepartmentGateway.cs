using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityManagementSystemDB.DAL.Model;

namespace UniversityManagementSystemDB.DAL.Gateway
{
    public class DepartmentGateway
    {
        private string conStr = WebConfigurationManager.ConnectionStrings["UnversityManagementSystem"].ConnectionString;
        public List<Department> GetAllDepartment()
        {
            List<Department> departments = new List<Department>();
            //string conStr = @"Server=DESKTOP-8D34V6S;Database=UniversityManagementSystem_DB;Integrated Security=true;";
            SqlConnection con = new SqlConnection(conStr);
            string query = "SELECT * FROM Departments";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Department department = new Department();
                department.Id = (int)dr["Id"];
                department.Name = dr["name"].ToString();
                department.Code = dr["code"].ToString();

                departments.Add(department);
            }
            dr.Close();
            con.Close();
            return departments;
        } 
    }
}