using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystemDB.DAL.Gateway;
using UniversityManagementSystemDB.DAL.Model;

namespace UniversityManagementSystemDB.BLL
{
    public class StudentManager
    {
        StudentGateway studentGateway = new StudentGateway();

        public List<Student> GetStudentDetails()
        {
            return studentGateway.GetStudentDetails();
        }

        public string Save(Student aStudent)
        {
            if (studentGateway.IsRegNoUnique(aStudent.RegNo))
            {
                return "Reg No already exist";
            }
            if (studentGateway.Save(aStudent) > 0)
            {
                return "Succesfilly Added";
            }
            else
            {
                return "Failed";
            }
        }

        public Student GetStudentByRegNo(string regNo)
        {
            return studentGateway.GetStudentByRegNo(regNo);
        }

        public string UpdateStudentData(Student aStudent)
        {
            int rowAffected = studentGateway.UpdateStudentData(aStudent);
            if (rowAffected > 0)
            {
                return "Updated Successfully!!";
            }
            return "Update Failed!!";
        }

        public Student GetStudentById(int id)
        {
            return studentGateway.GetStudentById(id);
        }

        public List<StudentWithDepartment_ViewModel> GetStudentWithDepartment()
        {
            return studentGateway.GetStudentWithDepartment();
        }

    }
}