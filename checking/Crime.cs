using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    class Crime
    {
        public int crimeID { get; set; }
        public string crimeType { get; set; }
        public string crimeDate { get; set; }
        public string location { get; set; }
        public int noOfPeopleArrest { get; set; }
    }
}
