using AppCode.BLL.Models;

namespace AppCode.BLL.Interfaces
{
    public interface ITeacherBLL
    {
        public Teacher GetTeacherById(int Id);

        public List<Teacher>? GetTeachers();
    }
}
