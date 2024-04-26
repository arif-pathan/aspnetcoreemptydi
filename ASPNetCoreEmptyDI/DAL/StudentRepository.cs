using ASPDotNetCEmptyDI.Interfaces;
using ASPDotNetCEmptyDI.Models;

namespace ASPDotNetCEmptyDI.DAL
{
    public class StudentRepository : IStudentRepository
    {

        public List<Student> DataSource()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { StudentId = 1, Name = "A", Branch = "A", Section = "A", Gender = "M" });
            students.Add(new Student() { StudentId = 2, Name = "B", Branch = "B", Section = "B", Gender = "F" });
            students.Add(new Student() { StudentId = 3, Name = "C", Branch = "C", Section = "C", Gender = "M" });
            return students;
        }
        public List<Student> GetAllStudents()
        {
            return DataSource();
        }

        public Student GetStudent(int id)
        {
            return DataSource().FirstOrDefault(a => a.StudentId == id);
        }
    }
}
