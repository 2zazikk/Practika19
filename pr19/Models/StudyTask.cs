using System;

namespace pr19.Models
{
    public class StudyTask
    {
        public string Subject { get; set; }

        public DateTime Deadline { get; set; }

        public bool Completed { get; set; }
    }
}