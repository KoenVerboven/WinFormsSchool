using AppCode.BLL.Models;

namespace AppCode.BLL.Interfaces
{
    public interface IStudentBLL
    {
        public Student? GetStudentById(int Id);

        public List<Student>? GetStudents();

        public bool AddStudent();

        public bool UpdateStudent();

        public bool DeleteStudent(int StudentId);
    }
}
