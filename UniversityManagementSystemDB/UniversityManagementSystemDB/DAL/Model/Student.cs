namespace UniversityManagementSystemDB.DAL.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
    }
}