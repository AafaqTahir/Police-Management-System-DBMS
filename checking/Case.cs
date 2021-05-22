using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    class Case
    {
        public int caseID { get; set; }
        public string caseType { get; set; }
        public string startingDate { get; set; }
        public string endingDate { get; set; }
        public string solved { get; set; }
        public int officerBatchID { get; set; }
        public int crimeID { get; set; }
        public int victimID { get; set; }

    }
}
