namespace SeminarClass.Models
{
    public class SeminarEnrolement
    {
        public List<double> MarksRecieved { get; set; }

        public string Id { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public string SeminarId { get; set; }
        public Seminar Seminar { get; set; }

        public double GetAvgToDate()
        {
            double avrage = 0;
            foreach(var mark in MarksRecieved)
            {
                avrage += mark;
            }

            return avrage / MarksRecieved.Count;
        }

        public double GetFinalMark()
        {
            return null;
        }
    }
}
