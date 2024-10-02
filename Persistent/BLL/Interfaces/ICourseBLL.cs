using AppCode.BLL.Models;


namespace AppCode.BLL.Interfaces
{
    public interface ICourseBLL
    {
        public List<Course> GetCoursesByStudentId(int studentId);
    }
}
