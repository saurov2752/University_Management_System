using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityManagementSystemDB.DAL.Model;

namespace UniversityManagementSystemDB.DAL.Gateway
{
    public class StudentGateway
    {
        private string conStr = WebConfigurationManager.ConnectionStrings["UnversityManagementSystem"].ConnectionString;

        public int Save(Student aStudent)
        {
            //string conStr = @"Server=DESKTOP-8D34V6S;Database=UniversityManagementSystem_DB;Integrated Security=true;";
            string query = "insert into Students (name,regNo,email,address,departmentId) values ('" + aStudent.Name + "','" + aStudent.RegNo
                + "','" + aStudent.Email + "','" + aStudent.Address + "','" + aStudent.DepartmentId + "')";

            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int noOfRow = cmd.ExecuteNonQuery();
            con.Close();

            return noOfRow;
        }


        public bool IsRegNoUnique(string regNo)
        {
            //string conStr = @"Server=DESKTOP-8D34V6S;Database=UniversityManagementSystem_DB;Integrated Security=true;";
            string query = "select * from Students where regNo = '" + regNo + "';";

            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            bool result = dr.HasRows;

            dr.Close();
            con.Close();

            return result;

        }


        public List<Student> GetStudentDetails()
        {
            //string conStr = @"Server=DESKTOP-8D34V6S;Database=UniversityManagementSystem_DB;Integrated Security=true;";
            string query = "select * from Students";

            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            List<Student> studentList = new List<Student>();

            while (dr.Read())
            {
                Student aStudent = new Student();
                aStudent.Id = (int)dr["id"];
                aStudent.Name = dr["name"].ToString();
                aStudent.RegNo = dr["regNo"].ToString();
                aStudent.Email = dr["email"].ToString();
                aStudent.Address = dr["address"].ToString();
                aStudent.DepartmentId = (int)dr["departmentId"];

                studentList.Add(aStudent);

            }
            dr.Close();
            con.Close();

            return studentList;
        }

        public Student GetStudentByRegNo(string regNo)
        {
            string query = "SELECT * FROM Students WHERE regNo = '" + regNo + "';";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();

            //bool result = dr.HasRows;
            Student aStudent = null;
            if (dr.HasRows)
            {
                aStudent = new Student();
                aStudent.Id = (int) dr["id"];
                aStudent.Name = dr["name"].ToString();
                aStudent.RegNo = dr["regNo"].ToString();
                aStudent.Email = dr["email"].ToString();
                aStudent.Address = dr["address"].ToString();
                aStudent.DepartmentId = (int)dr["departmentId"];
            }
            
            dr.Close();
            con.Close();

            return aStudent;

        }

        public int UpdateStudentData(Student aStudent)
        {
            string query = "UPDATE Students SET name='" + aStudent.Name + "', email='" + aStudent.Email + "', address='" +
                aStudent.Address + "',departmentId='" + aStudent.DepartmentId + "' WHERE regNo = '" + 
                aStudent.RegNo + "' ;";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowAffected;
        }

        public Student GetStudentById(int id)
        {
            string query = "SELECT * FROM Students WHERE id = '" + id + "';";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();

            //bool result = dr.HasRows;
            Student aStudent = null;
            if (dr.HasRows)
            {
                aStudent = new Student();
                aStudent.Id = (int)dr["id"];
                aStudent.Name = dr["name"].ToString();
                aStudent.RegNo = dr["regNo"].ToString();
                aStudent.Email = dr["email"].ToString();
                aStudent.Address = dr["address"].ToString();
                aStudent.DepartmentId = (int)dr["departmentId"];
            }

            dr.Close();
            con.Close();

            return aStudent;

        }

        public List<StudentWithDepartment_ViewModel> GetStudentWithDepartment()
        {
            string query = "select * from StudentWithDepartment";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            List<StudentWithDepartment_ViewModel> studentList = new List<StudentWithDepartment_ViewModel>();

            while (dr.Read())
            {
                StudentWithDepartment_ViewModel students = new StudentWithDepartment_ViewModel();

                students.StudentId = (int) dr["StudentId"];
                students.StudentName = (string) dr["StudentName"];
                students.RegNo = (string)dr["regNo"];
                students.Email = (string)dr["email"];
                students.Address = (string)dr["address"];
                students.DeptId = (int) dr["DeptId"];
                students.DeptName = (string)dr["DeptName"];
                students.Code = (string)dr["Code"];

                studentList.Add(students);
            }
            dr.Close();
            con.Close();

            return studentList;
        }

    }
}