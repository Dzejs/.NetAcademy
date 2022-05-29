namespace SeminarClass.Models
{
    public class Seminar
    {
        public string SeminarId { get; set; }
        public List<Student> WaitingList { get; set; }
        public Proffessor Proffessor { get; set; }
        public string ProffesorId { get; set; }
        public int TotalMarks { get; set; }
        public List<Course> Courses { get; set; }
        public List<SeminarEnrolement> Students { get; set; }

        public void AddStudent(Student student)
        {
            var validStudent = WaitingList.FirstOrDefault(x => x.StudentId == student.StudentId);
            if(validStudent != null)
            throw new Exception("This student is already in the waiting list!");

            WaitingList.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            var studentForRemoving = WaitingList.FirstOrDefault(x => x.StudentId == student.StudentId);
            if (studentForRemoving == null)
                throw new Exception("Student not found!");

            WaitingList.Remove(studentForRemoving);
        }
    }
}
