
using AppCode.BLL.Models;
using System.Data;
using System.Data.SqlClient;

namespace AppCode.DAL
{
    internal class StudentDal
    {
        public bool AddNewStudent(Student student)
        {
            try
            {
                var connectionString = "Data Source=KOENI7;Initial Catalog=School1;Integrated Security=True";
                var query = "Insert into Student" +
                            "(FirstName, MiddleName, LastName, StreetAndNumber, ZipCode, PhoneNumber, " +
                            "EmailAddress,Gender, DateOfBirth, MaritalStatusId, NationalRegisterNumber, Nationality," +
                            "MoederTongueId, Registrationdate ) " +
                            " values (" +
                                        "@FirstName, @MiddleName, @LastName, @StreetAndNumber, @ZipCode, @PhoneNumber," +
                                        "@EmailAddress, @Gender, @DateOfBirth,@MaritalStatusId," +
                                        " @NationalRegisterNumber,@Nationality,@MoederTongueId, @Registrationdate" +
                                    ")";
                
                CreateCommand(connectionString, query, student);

                return true;    
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public bool UpdateStudent(Student student) 
        {
            return true;
        }

        private static void CreateCommand(string connectionString, string queryString, Student student)
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                var command = new SqlCommand(queryString, connection);

                command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = student.Firstname;
                command.Parameters.Add("@MiddleName", SqlDbType.VarChar, 50).Value = student.MiddleName;
                command.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = student.LastName;
                command.Parameters.Add("@StreetAndNumber", SqlDbType.VarChar, 50).Value = student.StreetAndNumber;
                command.Parameters.Add("@ZipCode", SqlDbType.VarChar, 50).Value = student.ZipCode;
                command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 50).Value = student.PhoneNumber;
                command.Parameters.Add("@EmailAddress", SqlDbType.VarChar, 50).Value = student.EmailAddress;
                command.Parameters.Add("@Gender", SqlDbType.VarChar, 50).Value = 'M'; //student.Gender;
                command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime, 50).Value = student.DateOfBirth;
                command.Parameters.Add("@MaritalStatusId", SqlDbType.Int, 50).Value = 1;//
                command.Parameters.Add("@NationalRegisterNumber", SqlDbType.VarChar, 50).Value = student.NationalRegisterNumber;
                command.Parameters.Add("@Nationality", SqlDbType.Int).Value = 1;// student.Nationality; 
                command.Parameters.Add("@MoederTongueId", SqlDbType.Int).Value = 1; // student.MoederTongueId;
                command.Parameters.Add("@Registrationdate", SqlDbType.DateTime).Value = student.RegistrationDate;

                command.Connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
