using AttendanceManagementSystem.DAO;
using AttendanceManagementSystem.Model;
using System;
using System.Collections.Generic;
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

        public async ValueTask<List<Event>> GetAllEvent()
        {
            List<Event> listEvent = await new EventDAO().GetAll();
            return listEvent;
        }

        public bool AddNewEvent(Event e)
        {
            return new EventDAO().AddNewEvent(e);
        }

        public async ValueTask<Event> GetEventByID(string id)
        {
            Event ev = await new EventDAO().GetEventByID(id);
            return ev;
        }

        public Task<bool> DeleteEventByID(string id)
        {
            return new EventDAO().DeleteEventByID(id);
        }

        public async ValueTask<bool> UpdateEvent(Event newEvent)
        {
            bool result = await new EventDAO().UpdateEvent(newEvent);
            return result;
        }

        public async ValueTask<List<Event>> SelectByKeyWord(string Name)
        {
            List<Event> listEvent = await new EventDAO().SelectByKeyWord(Name);
            return listEvent;
        }
    }
}