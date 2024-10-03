﻿using AppCode.BLL.Interfaces;
using AppCode.BLL.Models;
using AppCode.DAL;

namespace AppCode.BLL.BLLClasses
{
    public class UserBLL : IUserBLL
    {

        List<User>? Users;

        public UserBLL()
        {
        }


        public List<User>? GetUsers()
        {
            var userDal = new UserDal();
            return userDal.GetUsers();
        }

        public User? GetUserByUserNameAndPassword(String userName,String passWord)
        {
            User? user = null;
            if (userName != string.Empty)
            {
                var userDal = new UserDal();
                return userDal.GetValidUser(userName, passWord);
            }
            return user;
        }

        [Obsolete]
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
