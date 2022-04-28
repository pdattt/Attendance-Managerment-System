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
        public async ValueTask<Attendee> GetByCardID(string id)
        {
            Attendee attendee = await new AttendeeDAO().GetByCardID(id);
            return attendee;
        }
    }
}
