using AppCode.BLL.Models;

namespace AppCode.BLL.BLLClasses
{
    public class UserBLL
    {

        List<User>? Users;

        public UserBLL()
        {
            FillUserList();
        }

        public User? GetUserByUserNameAndPassword(String UserName,String PassWord)
        {
            User? user = null;
            if (UserName != string.Empty)
            {
                user = Users.SingleOrDefault(p => p.UserName == UserName);
                //user = Users.SingleOrDefault(p => p.UserName == UserName && p.Password == PassWord); ToDo comment this out
            }
            return user;
        }

        private void FillUserList()
        {
            Users =
            [
                
                new()
                {
                    UserId = 1,
                    UserName = "admin",
                    Password = "schoolSoft4you",
                    SecurityGroupId = 0,
                    ActiveFrom = DateTime.Now,
                    Blocked = false,
                    PersonId =  0
                },
                new()
                {
                    UserId = 2,
                    UserName = "koenverboven",
                    Password = "rgSeg@45",
                    SecurityGroupId = 1,
                    ActiveFrom = DateTime.Now,
                    Blocked = false,
                    PersonId = 1
                },
                new()
                {
                    UserId = 3,
                    UserName = "mariapoels",
                    Password = "regreT@488",
                    SecurityGroupId = 1,
                    ActiveFrom = DateTime.Now,
                    Blocked = false,
                    PersonId = 2
                },
                new()
                {
                    UserId = 4,
                    UserName = "johanverboven",
                    Password = "threM@566",
                    SecurityGroupId = 1,
                    ActiveFrom = DateTime.Now,
                    Blocked = false,
                    PersonId = 3
                }
            ];
        }

    }
}
