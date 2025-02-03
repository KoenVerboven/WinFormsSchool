using AppCode.BLL.Models;

namespace AppCode.BLL.Interfaces
{
    internal interface IUserBLL
    {
        public List<User>? GetUsers();
    }
}
