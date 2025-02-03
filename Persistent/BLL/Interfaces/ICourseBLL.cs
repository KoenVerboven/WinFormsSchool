using AppCode.BLL.Models;


namespace AppCode.BLL.Interfaces
{
    public interface ICourseBLL
    {
        public List<Course> GetCourses();

        public Course GetCourseById(int courseId);

        public List<Course> GetCoursesByStudentId(int studentId);
    }
}
