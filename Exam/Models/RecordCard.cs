namespace Exam.Models
{
    public class RecordCard
    {
        public int Id { get; set; }
        public int RecordNumber { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public List<Record> Exams { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
