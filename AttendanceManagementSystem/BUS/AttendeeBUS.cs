using DoAnLapTrinhA.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.BUS
{
    public class AttendeeBUS
    {
        public string GetRandom(int lenght)
        {
            string letter = "0123456789";
            Random r = new Random((int)DateTime.Now.Ticks);

            string randomID = "AT";
            for (int i = 0; i < lenght; i++)
            {
                randomID += letter[r.Next(0, letter.Length - 1)];
            }
            return randomID;
        }

        public async ValueTask<bool> AddNewAttendee(Attendee attendee) { 
            List<Attendee> listAttendee = await new AttendeeDAO().GetAll();

            new AttendeeDAO().AddNewAttendee(attendee);
            return true;
        }
    }
}
