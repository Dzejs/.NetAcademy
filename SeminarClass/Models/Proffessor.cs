namespace SeminarClass.Models
{
    public class Proffessor : Person
    {
        public string StaffId { get; set; }
        public List<Seminar> Seminars { get; set; }

        public Proffessor(string name, DateTime birthDay, string email, Address address, string staffId) : base(name, birthDay, email, address)
        {
            StaffId = staffId;
        }

        public List<Seminar> GetSeminars()
        {
            return Seminars;
        }

        //public bool IsEligble(int seminarId)
        //{

        //}
    }
}
