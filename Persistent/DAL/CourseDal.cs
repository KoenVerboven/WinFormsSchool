using AppCode.BLL.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace AppCode.DAL
{
    internal class CourseDal
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["school"].ConnectionString;


        public List<Course> GetCourses()
        {
            var coursesList = new List<Course>();

            var query = "SELECT CourseId ,CourseName ,CourseStartDate ,CourseEndDate ,MinimumGradeToPassTheCourse," +
                            "MaximumTestCourseGrade ,CourseIsActive ,CourseTypeId ,CostPrice " +
                         "FROM Course " +
                         "ORDER BY CourseId ";

            using var connection = new SqlConnection(connectionString);
            SqlCommand command = new(query, connection);
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
                        CourseDescription = "",//  Convert.ToString(reader["CourseDescription"]),
                        CourseCode = "",//  Convert.ToString(reader["CourseCode"]),
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


        public Course GetCourseById(int courseId)
        {
            var query = "SELECT CourseId ,CourseName ,CourseStartDate ,CourseEndDate ,MinimumGradeToPassTheCourse," +
                            "MaximumTestCourseGrade ,CourseIsActive ,CourseTypeId ,CostPrice " +
                         "FROM Course " +
                         "WHERE CourseId = @CourseId";

            try
            {
                var courseDal = new CourseDal();
                var courses = courseDal.GetCoursesByStudentId(courseId);

                using var connection = new SqlConnection(connectionString);
                SqlCommand command = new(query, connection);
                command.Parameters.Add("@CourseId", SqlDbType.Int, 50).Value = courseId;
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
                            CourseDescription = "",//  Convert.ToString(reader["CourseDescription"]),
                            CourseCode = "",//  Convert.ToString(reader["CourseCode"]),
                            StartDate = Convert.ToDateTime(reader["CourseStartDate"]),
                            EndDate = Convert.ToDateTime(reader["CourseEndDate"]),
                            MinimumGradeToPassTheCourse = Convert.ToDouble(reader["MinimumGradeToPassTheCourse"]),
                            MaximumTestCourseGrade = Convert.ToInt32(reader["MaximumTestCourseGrade"]),
                            CourseType = null,
                            CoursePrice = Convert.ToDecimal(reader["CostPrice"]),
                            Teacher = null
                        };
                        return course;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public List<Course> GetCoursesByStudentId(int studentId)
        {
            var coursesList = new List<Course>();

            var query = "SELECT C.CourseId,CourseTestGrade,CourseName,CourseStartDate,CourseEndDate," +
                            "MinimumGradeToPassTheCourse ,MaximumTestCourseGrade,CourseIsActive,CourseTypeId,CostPrice " +
                        "FROM Student S inner join StudentCourse SC " +
                            "on S.StudentId = SC.StudentId inner join Course C " +
                            "on C.CourseId = SC.CourseId " +
                        "WHERE s.studentId = @StudentId " +
                        "ORDER BY coursestartdate desc ";

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
