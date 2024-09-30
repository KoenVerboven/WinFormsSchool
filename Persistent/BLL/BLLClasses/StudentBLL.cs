using AppCode.BLL.Enums;
using AppCode.BLL.Interfaces;
using AppCode.BLL.Models;
using AppCode.DAL;

namespace AppCode.BLL.BLLClasses
{
    public class StudentBLL : IStudentBLL
    {
        List<Student>? students;

        public StudentBLL()//ctor tab tab
        {
            FillStudentList();
        }

        public bool AddStudent(Student student)
        {
            var studentDal = new StudentDal();
            return studentDal.AddNewStudent(student); 
        }

        public bool DeleteStudent(int StudentId)
        {
            throw new NotImplementedException();
        }

        public Student? GetStudentById(int StudentId)
        {
            if (students == null)
            {
                return null;
            }
            return students.Single(p => p.PersonId == StudentId);
        }

        public List<Student>? GetStudents()
        {
            return students;
        }

        public bool UpdateStudent(Student student)
        {
            var studentDal = new StudentDal();
            return studentDal.UpdateStudent(student);
        }

        private void FillStudentList()
        {
            students =
              [
                  new()
                  {
                      PersonId = 1,
                      Firstname = "Koen",
                      MiddleName = "Frans Maria",
                      LastName = "Verboven",
                      StreetAndNumber = "MPad 3",
                      ZipCode = "5000",
                      PhoneNumber = null,
                      EmailAddress = "Koen@test.be",
                      Gender = Gender.Male,
                      DateOfBirth = new DateTime(1966, 6, 1),
                      MaritalStatus = MaritalStatus.Single,
                      NationalRegisterNumber = 45487487,
                      Nationality = Nationality.Belgian,
                      MoederTongueId = 6,
                      RegistrationDate = new DateTime(2021, 9, 1),
                      EnrolledCourse =
                        [
                            new()
                            {
                                CourseId = 1
                                ,
                                CourseName = "C# course senior",
                                CourseDescription = "",
                                CourseCode = "2BB",
                                StartDate = new DateTime(2022, 9, 2),
                                EndDate = new DateTime(2022, 11, 2),
                                CourseTestGrade = 8.5,
                                MinimumGradeToPassTheCourse = 5,
                                MaximumTestCourseGrade = 10,
                                CourseType = CourseType.NightSchool
                            },
                            new()
                            {
                                CourseId = 2
                                ,
                                CourseName = "Englisch basics",
                                CourseDescription = "",
                                CourseCode = "1CC",
                                StartDate = new DateTime(2023, 10, 2),
                                EndDate = new DateTime(2023, 12, 20),
                                CourseTestGrade = 6.5,
                                MinimumGradeToPassTheCourse = 5,
                                MaximumTestCourseGrade = 10,
                                CourseType = CourseType.NightSchool
                            },
                            new()
                            {
                                CourseId = 3
                                ,
                                CourseName = "Angular 7",
                                CourseDescription = "",
                                CourseCode = "2DD",
                                StartDate = new DateTime(2024, 1, 2),
                                EndDate = new DateTime(2024, 2, 20),
                                CourseTestGrade = 5.5,
                                MinimumGradeToPassTheCourse = 5,
                                MaximumTestCourseGrade = 10,
                                CourseType = CourseType.NightSchool
                            },
                            new()
                            {
                                CourseId = 4
                                ,
                                CourseName = "Spanish",
                                CourseDescription = "",
                                CourseCode = "10DD",
                                StartDate = new DateTime(2024, 1, 2),
                                EndDate = new DateTime(2024, 2, 20),
                                CourseTestGrade = 5.5,
                                MinimumGradeToPassTheCourse = 7,
                                MaximumTestCourseGrade = 10,
                                CourseType = CourseType.NightSchool
                            },
                            new()
                            {
                                CourseId = 5
                                ,
                                CourseName = "C# follow-up",
                                CourseDescription = "",
                                CourseCode = "11",
                                StartDate = new DateTime(2025, 1, 2),
                                EndDate = new DateTime(2036, 2, 20),
                                CourseTestGrade = null,
                                MinimumGradeToPassTheCourse = 7,
                                MaximumTestCourseGrade = 10,
                                CourseType = CourseType.NightSchool
                            },
                            new()
                            {
                                CourseId = 6
                                ,
                                CourseName = "HTML follow-up",
                                CourseDescription = "",
                                CourseCode = "11",
                                StartDate = new DateTime(2026, 1, 2),
                                EndDate = new DateTime(2036, 2, 20),
                                CourseTestGrade = null,
                                MinimumGradeToPassTheCourse = 7,
                                MaximumTestCourseGrade = 10,
                                CourseType = CourseType.NightSchool
                            },
                            new()
                            {
                                CourseId = 7
                                ,
                                CourseName = "AI follow-up",
                                CourseDescription = "",
                                CourseCode = "11",
                                StartDate = new DateTime(2026, 1, 2),
                                EndDate = new DateTime(2038, 2, 20),
                                CourseTestGrade = null,
                                MinimumGradeToPassTheCourse = 7,
                                MaximumTestCourseGrade = 10,
                                CourseType = CourseType.DaySchool
                            }
                        ]
                  },
                  new()
                  {
                      PersonId = 2,
                      Firstname = "Maria",
                      MiddleName = null,
                      LastName = "Poels",
                      StreetAndNumber = "MPad 3",
                      ZipCode = "5000",
                      PhoneNumber = null,
                      EmailAddress = "Maria@test.be",
                      Gender = Gender.Female,
                      DateOfBirth = new DateTime(1944, 4, 12),
                      MaritalStatus = MaritalStatus.Single,
                      NationalRegisterNumber = 45487487,
                      Nationality = Nationality.Belgian,
                      MoederTongueId = 6,
                      RegistrationDate = new DateTime(2023, 9, 2),
                      EnrolledCourse =
                        [
                            new()
                            {
                                CourseId = 1
                                ,
                                CourseName = "Wiskunde",
                                CourseDescription = "Integrals",
                                CourseCode = "2FF",
                                StartDate = new DateTime(202, 9, 2),
                                EndDate = new DateTime(2023, 9, 2),
                                CourseTestGrade = 8,
                                MinimumGradeToPassTheCourse = 5,
                                MaximumTestCourseGrade = 10,
                                CourseType = CourseType.DaySchool
                            },
                            new()
                            {
                                CourseId = 2
                                ,
                                CourseName = "Piano for beginners",
                                CourseDescription = "",
                                CourseCode = "1AC",
                                StartDate = new DateTime(2024, 1, 2),
                                EndDate = new DateTime(2024, 2, 20),
                                CourseTestGrade = 10,
                                MinimumGradeToPassTheCourse = 5,
                                MaximumTestCourseGrade = 10,
                                CourseType = CourseType.DaySchool
                            },
                            new()
                            {
                                CourseId = 3
                                ,
                                CourseName = "Piano Advanced",
                                CourseDescription = "",
                                CourseCode = "1AC",
                                StartDate = new DateTime(2024, 2, 3),
                                EndDate = new DateTime(2044, 2, 20),
                                CourseTestGrade = null,
                                MinimumGradeToPassTheCourse = 5,
                                MaximumTestCourseGrade = 10,
                            },
                        ]
                  },
                  new()
                  {
                      PersonId = 3,
                      Firstname = "Johan",
                      MiddleName = null,
                      LastName = "Verboven",
                      StreetAndNumber = "MPad 3",
                      ZipCode = "5000",
                      PhoneNumber = null,
                      EmailAddress = "Johan@test.be",
                      Gender = Gender.Male,
                      DateOfBirth = new DateTime(1969, 1, 31),
                      MaritalStatus = MaritalStatus.Single,
                      NationalRegisterNumber = 45487487,
                      Nationality = Nationality.Belgian,
                      MoederTongueId = 6,
                      RegistrationDate = new DateTime(2024, 9, 1),
                      EnrolledCourse =
                        [
                            new()
                            {
                                CourseId = 1
                                ,
                                CourseName = "Spanish",
                                CourseDescription = "",
                                CourseCode = "2BB",
                                StartDate = new DateTime(2024, 9, 2),
                                EndDate = new DateTime(2025, 2, 2)
                            }
                        ]
                  },
                  new()
                  {
                      PersonId = 4,
                      Firstname = "Jan",
                      MiddleName = null,
                      LastName = "Peeters",
                      StreetAndNumber = "Kerkstraat 50",
                      ZipCode = "5000",
                      PhoneNumber = null,
                      EmailAddress = null,
                      Gender = Gender.Male,
                      DateOfBirth = new DateTime(1999, 5, 4),
                      MaritalStatus = MaritalStatus.MarriedWithChilderen,
                      NationalRegisterNumber = 45487487,
                      Nationality = Nationality.Belgian,
                      MoederTongueId = 6,
                      RegistrationDate = new DateTime(2023, 9, 1),
                      EnrolledCourse =
                        [
                            new()
                            {
                                CourseId = 1
                                ,
                                CourseName = "C# course gevorderde",
                                CourseDescription = "",
                                CourseCode = "2BB",
                                StartDate = new DateTime(2023, 10, 2),
                                EndDate = new DateTime(2023, 12, 20)
                            }
                        ]
                  },
                  new()
                  {
                      PersonId = 5,
                      Firstname = "Peter",
                      MiddleName = null,
                      LastName = "Janssens",
                      StreetAndNumber = "Hoofdweg 455",
                      ZipCode = "6000",
                      PhoneNumber = null,
                      EmailAddress = "Peter@test.be",
                      Gender = Gender.Male,
                      DateOfBirth = new DateTime(1985, 1, 5),
                      MaritalStatus = MaritalStatus.Single,
                      NationalRegisterNumber = 45487487,
                      Nationality = Nationality.Belgian,
                      MoederTongueId = 6,
                      RegistrationDate = new DateTime(2023, 1, 1),
                      EnrolledCourse =
                        [
                            new()
                            {
                                CourseId = 1
                                ,
                                CourseName = "C# course gevorderde",
                                CourseDescription = "",
                                CourseCode = "2BB",
                                StartDate = new DateTime(2023, 1, 2),
                                EndDate = new DateTime(2023, 6, 2)
                            }
                        ]
                  },
                  new()
                  {
                      PersonId = 6,
                      Firstname = "Els",
                      MiddleName = null,
                      LastName = "Versmissen",
                      StreetAndNumber = "Kiekenstraat 2",
                      ZipCode = "2100",
                      PhoneNumber = null,
                      EmailAddress = "Els@test.be",
                      Gender = Gender.Female,
                      DateOfBirth = new DateTime(1988, 1, 31),
                      MaritalStatus = MaritalStatus.MarriedWithChilderen,
                      NationalRegisterNumber = 45487487,
                      Nationality = Nationality.Belgian,
                      MoederTongueId = 6,
                      RegistrationDate = new DateTime(2023, 9, 1)
                  },
                  new()
                  {
                      PersonId = 7,
                      Firstname = "Joris",
                      MiddleName = null,
                      LastName = "Gevers",
                      StreetAndNumber = "Kleinebaan 6",
                      ZipCode = "5000",
                      PhoneNumber = null,
                      EmailAddress = "Joris@test.be",
                      Gender = Gender.Male,
                      DateOfBirth = new DateTime(1999, 3, 29),
                      MaritalStatus = MaritalStatus.MarriedWithChilderen,
                      NationalRegisterNumber = 45487487,
                      Nationality = Nationality.Belgian,
                      MoederTongueId = 6,
                      RegistrationDate = new DateTime(2023, 9, 1)
                  },
                  new()
                  {
                      PersonId = 8,
                      Firstname = "Greet",
                      MiddleName = null,
                      LastName = "Colpaert",
                      StreetAndNumber = "Fazantenbaan 1",
                      ZipCode = "7000",
                      PhoneNumber = null,
                      EmailAddress = null,
                      Gender = Gender.Female,
                      DateOfBirth = new DateTime(1998, 1, 5),
                      MaritalStatus = MaritalStatus.Divorced,
                      NationalRegisterNumber = 45487487,
                      Nationality = Nationality.Belgian,
                      MoederTongueId = 6,
                      RegistrationDate = new DateTime(2023, 9, 1)
                  },
              ];
        }
    }
}
