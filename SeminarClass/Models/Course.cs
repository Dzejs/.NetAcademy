namespace SeminarClass.Models
{
    public class Course
    {
        public string CourseId { get; set; }
        public List<double> Fees { get; set; }
        public Seminar Seminar { get; set; }
        public string SeminarId { get; set; }


        public void GetDescription()
        {

        }
    }
}
