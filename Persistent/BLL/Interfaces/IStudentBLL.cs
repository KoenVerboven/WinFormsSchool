using AppCode.BLL.Models;

namespace AppCode.BLL.Interfaces
{
    public interface IStudentBLL
    {
        public Student? GetStudentById(int Id);

        public List<Student>? GetStudents();

        public bool AddStudent(Student student);

        public bool UpdateStudent(Student student);

        public bool DeleteStudent(int StudentId);
    }
}
