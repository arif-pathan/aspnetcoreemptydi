using ASPDotNetCEmptyDI.Models;

namespace ASPDotNetCEmptyDI.Interfaces
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);
        List<Student> GetAllStudents();
    }
}
