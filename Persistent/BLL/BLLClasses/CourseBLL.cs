using AppCode.BLL.Interfaces;
using AppCode.BLL.Models;
using AppCode.DAL;


namespace AppCode.BLL.BLLClasses
{
    public class CourseBLL : ICourseBLL
    {
        public List<Course> GetCoursesByStudentId(int studentId)
        {
            var courseDAL = new CourseDal();
            return courseDAL.GetCoursesByStudentId(studentId);
        }
    }
}
