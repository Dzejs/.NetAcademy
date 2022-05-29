namespace SeminarClass.Models
{
    public class Student : Person
    {
        public string StudentId { get; set; }
        public Student(string name, DateTime birthDay, string email, Address address, string studentId) : base(name, birthDay, email, address)
        {
            StudentId = studentId;
        }

        public List<SeminarEnrolement> Seminars { get; set; }
    }
}
