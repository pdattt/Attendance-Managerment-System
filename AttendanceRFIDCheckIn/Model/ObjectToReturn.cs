using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceRFIDCheckIn.Model
{
    public class ObjectToReturn
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public ObjectToReturn(string id, string name, string date, string hour)
        {
            Id = id;
            Name = name;
            Date = date;
            Hour = hour;
        }
    }
}
