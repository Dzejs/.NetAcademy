namespace Exam.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int RecordCardId { get; set; }
        public RecordCard RecordCard { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
