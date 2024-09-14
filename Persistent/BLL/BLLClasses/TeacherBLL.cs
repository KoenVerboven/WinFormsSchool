using AppCode.BLL.Enums;
using AppCode.BLL.Interfaces;
using AppCode.BLL.Models;

namespace AppCode.BLL.BLLClasses
{
    public class TeacherBLL : ITeacherBLL
    {
        List<Teacher>? teachers;

        public TeacherBLL()
        {
            FillStudentList();
        }


        public Teacher GetTeacherById(int teacherId)
        {
            return teachers.Single(p => p.PersonId == teacherId); ;
        }

        public List<Teacher>? GetTeachers()
        {
            return teachers;
        }

        private void FillStudentList()
        {
            teachers =
            [
                  new()
                  {
                      PersonId = 1,
                      Firstname = "Mark",
                      MiddleName = null,
                      LastName = "Verstraaten",
                      StreetAndNumber = "Bloemenweg 5",
                      ZipCode = "5000",
                      PhoneNumber = null,
                      EmailAddress = null,
                      Gender = Gender.Male,
                      DateOfBirth = new DateTime(1988, 9, 2),
                      MaritalStatus = MaritalStatus.MarriedWithChilderen,
                      NationalRegisterNumber = 45487487,
                      Nationality = Nationality.Belgian,
                      MoederTongueId = 6,
                      HireDate = new DateTime(2018, 9, 1),
                      LeaveDate = null,
                      HighestDegree = HighestDegree.HighSchool,
                      StudyDirection = StudyDirection.Chemistry
                  },
                new()
                {
                    PersonId = 2,
                    Firstname = "Els",
                    MiddleName = null,
                    LastName = "Vervoort",
                    StreetAndNumber = "Rozenpad 1",
                    ZipCode = "5000",
                    PhoneNumber = null,
                    EmailAddress = null,
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(1989, 4, 15),
                    MaritalStatus = MaritalStatus.Widow,
                    NationalRegisterNumber = 45487487,
                    Nationality = Nationality.Belgian,
                    MoederTongueId = 6,
                    HireDate = new DateTime(2019, 9, 1),
                    LeaveDate = null,
                    HighestDegree = HighestDegree.HighSchool,
                    StudyDirection = StudyDirection.Electronics
                },
                new()
                {
                    PersonId = 3,
                    Firstname = "Peter",
                    MiddleName = null,
                    LastName = "Michiels",
                    StreetAndNumber = "Berkenlei 9",
                    ZipCode = "5000",
                    PhoneNumber = null,
                    EmailAddress = null,
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1985, 2, 19),
                    MaritalStatus = MaritalStatus.Married,
                    NationalRegisterNumber = 45487487,
                    Nationality = Nationality.Belgian,
                    MoederTongueId = 6,
                    HireDate = new DateTime(2022, 9, 1),
                    LeaveDate = null,
                    HighestDegree = HighestDegree.University,
                    StudyDirection = StudyDirection.Chemistry
                },
                new()
                {
                    PersonId = 4,
                    Firstname = "An",
                    MiddleName = null,
                    LastName = "Verbeeck",
                    StreetAndNumber = "korenlaan 2",
                    ZipCode = "5000",
                    PhoneNumber = null,
                    EmailAddress = null,
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(1988, 2, 15),
                    MaritalStatus = MaritalStatus.Married,
                    NationalRegisterNumber = 45487487,
                    Nationality = Nationality.Belgian,
                    MoederTongueId = 6,
                    HireDate = new DateTime(2022, 9, 1),
                    LeaveDate = null,
                    HighestDegree = HighestDegree.University,
                    StudyDirection = StudyDirection.Chemistry
                },
                new()
                {
                    PersonId = 5,
                    Firstname = "Nadine",
                    MiddleName = null,
                    LastName = "Grootarts",
                    StreetAndNumber = "Brusselselaan 502",
                    ZipCode = "5000",
                    PhoneNumber = null,
                    EmailAddress = null,
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(1985, 2, 19),
                    MaritalStatus = MaritalStatus.Married,
                    NationalRegisterNumber = 45487487,
                    Nationality = Nationality.Belgian,
                    MoederTongueId = 6,
                    HireDate = new DateTime(2022, 9, 1),
                    LeaveDate = null,
                    HighestDegree = HighestDegree.University,
                    StudyDirection = StudyDirection.Languages
                },
                new()
                {
                    PersonId = 6,
                    Firstname = "Pascal",
                    MiddleName = null,
                    LastName = "Neutenboom",
                    StreetAndNumber = "Beersebaan 45",
                    ZipCode = "5000",
                    PhoneNumber = null,
                    EmailAddress = null,
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1995, 2, 19),
                    MaritalStatus = MaritalStatus.Married,
                    NationalRegisterNumber = 45487487,
                    Nationality = Nationality.Belgian,
                    MoederTongueId = 6,
                    HireDate = new DateTime(2022, 9, 1),
                    LeaveDate = null,
                    HighestDegree = HighestDegree.HighSchool,
                    StudyDirection = StudyDirection.Electronics
                },
                new()
                {
                    PersonId = 7,
                    Firstname = "Veerle",
                    MiddleName = null,
                    LastName = "Peeters",
                    StreetAndNumber = "Antwerpseweg 5666",
                    ZipCode = "5000",
                    PhoneNumber = null,
                    EmailAddress = null,
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(2001, 2, 19),
                    MaritalStatus = MaritalStatus.Married,
                    NationalRegisterNumber = 45487487,
                    Nationality = Nationality.Belgian,
                    MoederTongueId = 6,
                    HireDate = new DateTime(2022, 9, 1),
                    LeaveDate = null,
                    HighestDegree = HighestDegree.HighSchool,
                    StudyDirection = StudyDirection.Languages
                },
            ];
        }

    }
}
