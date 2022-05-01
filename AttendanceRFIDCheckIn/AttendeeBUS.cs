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
        public async ValueTask<Attendee> GetByCardID(string cardID)
        {
            List<Attendee> attendees = await new AttendeeDAO().GetAllAttendee();
            foreach (Attendee attendee in attendees)
                if (attendee.CardID == cardID)
                    return attendee;

            return null;
        }
    }
}
