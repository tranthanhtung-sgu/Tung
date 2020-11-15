using System.Collections.Generic;

namespace Domain.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string description { get; set; }
        public string photo { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public List<Class> Classes { get; set; }

    }
}