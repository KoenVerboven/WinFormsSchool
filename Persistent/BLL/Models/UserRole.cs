

namespace AppCode.BLL.Models
{
    public enum Role
    {
        Admin,
        student,
        parent,
        teacher,
        developper
    }

    internal class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public IList<Role>? RolesList { get; set; }
    }
}
