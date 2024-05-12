using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mobility_Handler.Models
{
    public class Student : Person
    {
        public string Country { get; set; }
        public string City { get; set; }    
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Motivation { get; set; }
        public string Faculty { get; set; }
        public string FieldOfStudy { get; set; }
        public string ECTS { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        public bool CheckPassword(string password)
        {
            return Password == password;
        }

    }
}
