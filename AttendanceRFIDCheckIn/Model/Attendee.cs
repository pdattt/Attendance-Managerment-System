using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceRFIDCheckIn.Model
{
    public class Attendee
    {
        public string AttendeeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int CardID { get; set; }
        public string Role { get; set; }
    }
}
