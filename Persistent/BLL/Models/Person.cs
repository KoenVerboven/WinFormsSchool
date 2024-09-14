
using AppCode.BLL.Enums;

namespace AppCode.BLL.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public required string Firstname { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public required string StreetAndNumber { get; set; }
        public required string ZipCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public int NationalRegisterNumber { get; set; }
        public Nationality Nationality { get; set; }
        public int MoederTongueId { get; set; }
    }
}
