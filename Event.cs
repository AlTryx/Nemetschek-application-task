using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSystem
{
    internal class Event
    {
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string[] Lecturers { get; set; }


    }
}
