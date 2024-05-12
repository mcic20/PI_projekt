using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mobility_Handler.Models
{
    public class FPA : Person
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Faculty { get; set; }
        public string FieldOfStudy { get; set; }

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
