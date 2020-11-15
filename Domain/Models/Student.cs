using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public DateTime dob { get; set; }
        public string Address { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set;}
        public List<StudentInClass> studentInClasses { get; set; }
        public List<Payment> payments { get; set; }
    }
}