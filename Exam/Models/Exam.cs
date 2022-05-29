namespace Exam.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int ExamNumber { get; set; }
        public List<ExamsTaken> Students { get; set; }
        public List<Sit> ExamAttendees { get; set; }
        public List<Record> RecordCards { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
