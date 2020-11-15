using System;

namespace Domain.Models
{   
    public class User
    {
        public int id {get; set;}
        public string username {get; set;}
        public DateTime birthday {get; set;}
        public int phonenumber {get; set; }
        public string password {get; set; }
    }
}