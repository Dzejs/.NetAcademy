namespace Exam.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RecordCardId { get; set; }
        public RecordCard RecordCard { get; set; }
        public List<Exam> Exams { get; set; }
    }
}
