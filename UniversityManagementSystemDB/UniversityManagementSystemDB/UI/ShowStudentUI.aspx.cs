using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityManagementSystemDB.BLL;
using UniversityManagementSystemDB.DAL.Model;

namespace UniversityManagementSystemDB.UI
{
    public partial class ShowStudentUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowStudentData();
        }

        public void ShowStudentData()
        {
            showStudentGridView.DataSource = studentManager.GetStudentWithDepartment();
            showStudentGridView.DataBind();
        }

        
    }
}