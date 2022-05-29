namespace Exam.Models
{
    public class Sit
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int ExamAttendeesId { get; set; }
        public ExamAttendees ExamAttendees { get; set; }
    }
}
