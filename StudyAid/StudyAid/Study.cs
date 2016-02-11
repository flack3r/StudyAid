using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAid
{
    class Study
    {
        public string StudyName { get; set; }
        public string hours { get; set; }
        public string minuits { get; set; }
        public string seconds { get; set; }

        public Study(string _name, string _hours, string _minuits, string _seconds)
        {
            StudyName = _name;
            hours = _hours;
            minuits = _minuits;
            seconds = _seconds;
        }
    }
}
