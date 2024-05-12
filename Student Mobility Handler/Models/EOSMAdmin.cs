using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mobility_Handler.Models
{
    public class EOSMAdmin : Person
    {
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
