using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityManagementSystemDB.BLL;
using UniversityManagementSystemDB.DAL.Model;

namespace UniversityManagementSystemDB.UI
{
    public partial class UpdateStudentUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                if (id != 0)
                {
                    Student aStudent = studentManager.GetStudentById(id);

                    if (aStudent != null)
                    {
                        nameTextBox.Text = aStudent.Name;
                        regNoTextBox.Text = aStudent.RegNo;
                        emailTextBox.Text = aStudent.Email;
                        addressTextBox.Text = aStudent.Address;
                        departmentTextBox.Text = aStudent.DepartmentId.ToString();

                        notificationLabel.Text = string.Empty;

                        updateButton.Enabled = true;
                    }
                    else
                    {
                        nameTextBox.Text = string.Empty;
                        emailTextBox.Text = string.Empty;
                        addressTextBox.Text = string.Empty;
                        departmentTextBox.Text = string.Empty;

                        notificationLabel.Text = "Reg. No is not found!!";

                        updateButton.Enabled = false;
                    }
                }
            }

            //updateButton.Enabled = false;
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNo = regNoTextBox.Text;
            Student aStudent = studentManager.GetStudentByRegNo(regNo);
            if (aStudent != null)
            {
                nameTextBox.Text = aStudent.Name;
                emailTextBox.Text = aStudent.Email;
                addressTextBox.Text = aStudent.Address;
                departmentTextBox.Text = aStudent.DepartmentId.ToString();

                notificationLabel.Text = string.Empty;

                updateButton.Enabled = true;
            }
            else
            {
                nameTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;
                addressTextBox.Text = string.Empty;
                departmentTextBox.Text = string.Empty;

                notificationLabel.Text = "Reg. No is not found!!";

                updateButton.Enabled = false;
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.DepartmentId = Convert.ToInt32(departmentTextBox.Text);

            notificationLabel.Text = studentManager.UpdateStudentData(aStudent);
        }
    }
}