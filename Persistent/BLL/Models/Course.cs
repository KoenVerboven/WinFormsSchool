
namespace AppCode.BLL.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public required string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double? CourseTestGrade { get; set; }
        public double? MinimumGradeToPassTheCourse { get; set; }
        public int? MaximumTestCourseGrade { get; set; }
        public bool? TestPassed { get => TestPassedMethod(); }
        private bool? TestPassedMethod ()
        {
           
            if (CourseTestGrade != null && MinimumGradeToPassTheCourse != null)
            {
                
                if (CourseTestGrade > MinimumGradeToPassTheCourse)
                {
                    return true;
                }
                else return false;

            }
            else return null;

        }
        public bool CourseIsActive { get => CourseIsActiveMethod(); }
        private bool CourseIsActiveMethod()
        {
            if (EndDate > DateTime.Now)
            { 
                return true; 
            }
            else return false;
        }
    }
}
