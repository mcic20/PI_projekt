using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mobility_Handler.Data
{
    public class FinalChoice
    {
        public int Id {  get; set; }
        public string Choice { get; set; }
        public int IdStudent { get; set; }
        public int IdEOSM { get; set; }
        public string Accepted { get; set; }

    }
}
