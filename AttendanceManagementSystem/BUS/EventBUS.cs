using AttendanceManagementSystem.DAO;
using AttendanceManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.BUS
{
    public class EventBUS
    {
        public string GetRandom(int lenght)
        {
            string letter = "0123456789";
            Random r = new Random((int)DateTime.Now.Ticks);

            string randomID = "EV";
            for (int i = 0; i < lenght; i++)
            {
                randomID += letter[r.Next(0, letter.Length - 1)];
            }
            return randomID;
        }

        public async ValueTask<List<Event>> SelectAll()
        {
            List<Event> listEvent= await new EventDAO().GetAll();
            return listEvent;
        }

        public async ValueTask<bool> AddEvent(Event e)
        {
            List<Event> listEvent = await new EventDAO().GetAll();

            new EventDAO().AddNewEvent(e);
            return true;
        }

        public async ValueTask<Event> GetDetails(string id)
        {
            Event ev = await new EventDAO().GetByID(id);
            return ev;
        }
    }
}
