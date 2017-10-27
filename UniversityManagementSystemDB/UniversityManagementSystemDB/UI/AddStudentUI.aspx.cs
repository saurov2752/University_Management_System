using System;
using System.Data.SqlClient;
using UniversityManagementSystemDB.BLL;
using UniversityManagementSystemDB.DAL.Model;

namespace UniversityManagementSystemDB.UI
{
    public partial class AddStudentUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        DepartmentManager departmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                departmentDropDownList.DataTextField = "Name";
                departmentDropDownList.DataValueField = "Id";
                departmentDropDownList.DataSource = departmentManager.GetAllDepartment();
                departmentDropDownList.DataBind();
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addreassTextBox.Text;
            aStudent.DepartmentId = Convert.ToInt32(departmentDropDownList.SelectedValue);

            Response.Write(studentManager.Save(aStudent));
        }



    }
}