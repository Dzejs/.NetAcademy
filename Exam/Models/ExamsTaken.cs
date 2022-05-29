﻿namespace Exam.Models
{
    public class ExamsTaken
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
