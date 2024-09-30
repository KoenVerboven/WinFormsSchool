
using System;


namespace AppCode.DAL
{
    internal class StudentDal
    {
        

        public void AddNewStudent()
        {
            string connectionString =  "Data Source=.;Initial Catalog=;Integrated Security=True";
            string query = "Insert into Student values (";
           // using SqlConnection();
        }

        //oplossing:
        //https://stackoverflow.com/questions/49035178/unable-to-locate-system-data-sqlclient-reference


        //https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection?view=netframework-4.8.1
        //private static void CreateCommand(string queryString,
        //      string connectionString)
        //{
        //    using (SqlConnection connection = new SqlConnection(
        //               connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(queryString, connection);
        //        command.Connection.Open();
        //        command.ExecuteNonQuery();
        //    }
        //}


    }
}
