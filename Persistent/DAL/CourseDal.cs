using AppCode.BLL.Models;
using System.Data.SqlClient;
using System.Data;

namespace AppCode.DAL
{
    internal class CourseDal
    {

        const string connectionString = "Data Source=KOENI7;Initial Catalog=School1;Integrated Security=True";

        public List<Course> GetCoursesByStudentId(int studentId)
        {
            var coursesList = new List<Course>();

            var query = "SELECT C.CourseId,CourseTestGrade,CourseName,CourseStartDate,CourseEndDate,";
            query += "MinimumGradeToPassTheCourse ,MaximumTestCourseGrade,CourseIsActive,CourseTypeId,CostPrice ";
            query += "FROM Student S inner join StudentCourse SC ";
            query += "on S.StudentId = SC.StudentId inner join Course C ";
            query += "on C.CourseId = SC.CourseId ";
            query += "WHERE s.studentId = @StudentId ";
            query += "ORDER BY coursestartdate desc ";


            using var connection = new SqlConnection(connectionString);
            SqlCommand command = new(query, connection);
            command.Parameters.Add("@StudentId", SqlDbType.Int, 50).Value = studentId;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var course = new Course()
                    {
                        CourseId = Convert.ToInt32(reader["CourseId"]),
                        CourseName = Convert.ToString(reader["CourseName"]),
                        CourseTestGrade = 1, //Convert.ToDouble(reader["CourseTestGrade"]), //is meestal null
                        StartDate = Convert.ToDateTime(reader["CourseStartDate"]),
                        EndDate = Convert.ToDateTime(reader["CourseEndDate"]),
                        MinimumGradeToPassTheCourse = Convert.ToDouble(reader["MinimumGradeToPassTheCourse"]),
                        MaximumTestCourseGrade = Convert.ToInt32(reader["MaximumTestCourseGrade"]),
                        CourseType = null,
                        CoursePrice = Convert.ToDecimal(reader["CostPrice"]),
                        Teacher = null
                    };
                    coursesList.Add(course);
                }
            }
            reader.Close();
            return coursesList;
        }


    }
}
