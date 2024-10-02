
using AppCode.BLL.Models;
using System.Data;
using System.Data.SqlClient;

namespace AppCode.DAL
{

    public enum RecordAction
    {
        insert,
        update,
        delete,
    }

    internal class StudentDal
    {
        const string connectionString = "Data Source=KOENI7;Initial Catalog=School1;Integrated Security=True";

        public List<Student> GetStudents()
        {
            var studentsList = new List<Student>();

            var query = "SELECT ";
            query += "StudentId ,FirstName ,MiddleName ,LastName ,StreetAndNumber  ,ZipCode,";
            query += "PhoneNumber ,EmailAddress ,Gender ,DateOfBirth ,MaritalStatusId  ,NationalRegisterNumber,";
            query += "Nationality ,MoederTongueId ,LanguageSkill ,Registrationdate ";
            query += "FROM Student ";
            query += "ORDER BY LastName ";

            using var connection = new SqlConnection(connectionString);
            SqlCommand command = new(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var student = new Student()
                    {
                        PersonId = Convert.ToInt32(reader["StudentId"]),
                        LastName = Convert.ToString(reader["LastName"]),
                        MiddleName = Convert.ToString(reader["MiddleName"]),
                        Firstname = Convert.ToString(reader["FirstName"]),
                        StreetAndNumber = Convert.ToString(reader["StreetAndNumber"]),
                        ZipCode = Convert.ToString(reader["ZipCode"]),
                        PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                        EmailAddress = Convert.ToString(reader["EmailAddress"]),
                        //Gender = ComboBoxGender.SelectedIndex
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                        MoederTongueId = 1,
                        // = ComboBoxNationality.SelectedIndex,
                        RegistrationDate = Convert.ToDateTime(reader["Registrationdate"])
                    };
                    studentsList.Add(student);
                }
            }
            reader.Close();
            return studentsList;
        }


        public Student GetStudentById(int studentId)
        {
            var query = "SELECT ";
            query += "StudentId ,FirstName ,MiddleName ,LastName ,StreetAndNumber  ,ZipCode,";
            query += "PhoneNumber ,EmailAddress ,Gender ,DateOfBirth ,MaritalStatusId  ,NationalRegisterNumber,";
            query += "Nationality ,MoederTongueId ,LanguageSkill ,Registrationdate ";
            query += "FROM Student ";
            query += "WHERE StudentId = @StudentId";

            try
            {
                using var connection = new SqlConnection(connectionString);
                SqlCommand command = new(query, connection);
                command.Parameters.Add("@StudentId", SqlDbType.Int, 50).Value = studentId;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var student = new Student()
                        {
                            PersonId = Convert.ToInt32(reader["StudentId"]),
                            LastName = Convert.ToString(reader["LastName"]),
                            MiddleName = Convert.ToString(reader["MiddleName"]),
                            Firstname = Convert.ToString(reader["FirstName"]),
                            StreetAndNumber = Convert.ToString(reader["StreetAndNumber"]),
                            ZipCode = Convert.ToString(reader["ZipCode"]),
                            PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                            EmailAddress = Convert.ToString(reader["EmailAddress"]),
                            //Gender = ComboBoxGender.SelectedIndex
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            MoederTongueId = 1,
                            // = ComboBoxNationality.SelectedIndex,
                            RegistrationDate = Convert.ToDateTime(reader["Registrationdate"])
                        };
                        return student;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public bool AddNewStudent(Student student)
        {
            try
            {
                var query = "Insert into Student" +
                            "(FirstName, MiddleName, LastName, StreetAndNumber, ZipCode, PhoneNumber, " +
                            "EmailAddress,Gender, DateOfBirth, MaritalStatusId, NationalRegisterNumber, Nationality," +
                            "MoederTongueId, Registrationdate ) " +
                            " values (" +
                                        "@FirstName, @MiddleName, @LastName, @StreetAndNumber, @ZipCode, @PhoneNumber," +
                                        "@EmailAddress, @Gender, @DateOfBirth,@MaritalStatusId," +
                                        " @NationalRegisterNumber,@Nationality,@MoederTongueId, @Registrationdate" +
                                    ")";
                
                CreateCommand(connectionString, query, student, RecordAction.insert);

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
            var query = "UPDATE student " +
                        "SET " +
                        "FirstName = @FirstName, " +
                        "LastName = @LastName, " +
                        "MiddleName = @MiddleName, " +
                        "StreetAndNumber = @StreetAndNumber, " +
                        "ZipCode = @ZipCode, " +
                        "PhoneNumber = @PhoneNumber, " +
                        "EmailAddress = @EmailAddress, " +
                        "Gender = @Gender, " +
                        "DateOfBirth = @DateOfBirth, " +
                        "MaritalStatusId = @MaritalStatusId, " +
                        "NationalRegisterNumber = @NationalRegisterNumber, " +
                        "Nationality = @Nationality, " +
                        "MoederTongueId = @MoederTongueId " +
                        "WHERE StudentId = @StudentId ";

            try
            {
                CreateCommand(connectionString, query, student, RecordAction.update);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteStudent(int studentId)
        {
            var query = "delete from student where StudentId = @StudentId";
            using var connection = new SqlConnection(connectionString);

            try
            {
                
                SqlCommand command = new(query, connection);
                command.Parameters.Add("@StudentId", SqlDbType.Int, 50).Value = studentId;
                command.Connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
         }



        private static void CreateCommand(string connectionString, string queryString, Student student, RecordAction action)
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                var command = new SqlCommand(queryString, connection);

                if(action == RecordAction.update)
                {
                    command.Parameters.Add("@StudentId", SqlDbType.Int, 50).Value = student.PersonId;
                }
                if (action == RecordAction.insert)
                {
                    command.Parameters.Add("@Registrationdate", SqlDbType.DateTime).Value = student.RegistrationDate;
                }

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
