
using System.Data.SqlClient;

namespace AppCode.DAL
{
    internal class StudentDal
    {
        public bool AddNewStudent()
        {
            try
            {
                var connectionString = "Data Source=KOENI7;Initial Catalog=School1;Integrated Security=True";
                var query = "Insert into Student(FirstName, MiddleName, LastName, StreetAndNumber, ZipCode, PhoneNumber, Gender, DateOfBirth, MaritalStatusId, NationalRegisterNumber, Nationality, [MoederTongueId], Registrationdate ) values ('Koentje', 'Maria Frans', 'Verboven', 'Mpad 3', '2350', '08123445', 'M', '1966-06-01', 2, 1783278328, 1, 1, '2024-06-01  10:00:00')";
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

        private static void CreateCommand(string connectionString, string queryString)
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                var command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
