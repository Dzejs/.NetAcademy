namespace Exam.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<ExamsTaken> Exams { get; set; }
        public int RecordCardId { get; set; }
        public RecordCard RecordCard { get; set; }

    }
}
