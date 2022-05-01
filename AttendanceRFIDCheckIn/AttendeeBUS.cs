using AttendanceRFIDCheckIn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceRFIDCheckIn
{
    public class AttendeeBUS
    {
        public async ValueTask<string> GetByCardID(string id)
        {
            List<Attendee> attendees = await new AttendeeDAO().GetAllAttendee();

            

            return "aa";
        }
    }
}
