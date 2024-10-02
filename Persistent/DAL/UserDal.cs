using AppCode.BLL.Models;
using System.Data;
using System.Data.SqlClient;

namespace AppCode.DAL
{
    internal class UserDal
    {
        const string connectionString = "Data Source=KOENI7;Initial Catalog=School1;Integrated Security=True";

        public User GetValidUser(string userName, string password)
        {

            var query = "SELECT UserId, SecurityGroupId, ActiveFrom, Blocked, PersonId ";
            query +=    "FROM InlogUser ";
            query += "WHERE UserName = @UserName ";
            //query +=      "and UserPassword = @UserPassword";
            query +=      "and Blocked = 0 ";
            query +=      "and ActiveFrom<getdate() ";

            using var connection = new SqlConnection(connectionString);
            SqlCommand command = new(query, connection);
            command.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = userName;
            command.Parameters.Add("@UserPassword", SqlDbType.VarChar, 50).Value = password;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();//executenonquery

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var user = new User()
                    {
                        SecurityGroupId = Convert.ToInt32(reader["SecurityGroupId"]),
                        PersonId = Convert.ToInt32(reader["PersonId"]),
                    };
                    return user;
                }
            }

            return null;
        }
    }
}
