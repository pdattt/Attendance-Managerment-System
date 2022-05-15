using DoAnLapTrinhA.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.BUS
{
    public class AttendeeBUS
    {
        private readonly AttendeeDAO _data;

        public AttendeeBUS()
        {
            _data = new AttendeeDAO();
        }

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

        public async Task<List<Attendee>> GetAllAttendee()
        {
            return await _data.GetAllAttendee();
        }

        public bool AddNewAttendee(Attendee attendee)
        {
            return _data.AddNewAttendee(attendee);
        }

        public async Task<Attendee> GetAttendeeByID(string id)
        {
            return await _data.GetByID(id);
        }

        public async Task<bool> UpdateAttendee(Attendee newAttendee)
        {
            return await _data.UpdateAttendee(newAttendee);
        }

        public async Task<bool> CheckCardIDExist(string ID)
        {
            List<Attendee> attendees = await _data.GetAllAttendee();

            foreach (Attendee attendee in attendees)
                if (attendee.CardID == ID)
                    return true;

            return false;
        }

        public async Task<bool> DeleteAttendeeByID(string id)
        {
            return await _data.DeleteAttendeeByID(id);
        }
    }
}