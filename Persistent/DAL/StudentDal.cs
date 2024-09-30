using System.Data.SqlClient;

namespace AppCode.DAL
{
    internal class StudentDal
    {
        public bool AddNewStudent()
        {
            try
            {
                string connectionString = "Data Source=.;Initial Catalog=;Integrated Security=True";
                string query = "Insert into Student values (";

                CreateCommand(connectionString, query);

                return true;    
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public bool UpdateStudent() 
        {
            return true;
        }

        private static void CreateCommand(string queryString, string connectionString)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
