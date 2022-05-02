﻿using DoAnLapTrinhA.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            List<Attendee> listAttendee = await new AttendeeDAO().GetAllAttendee();



            new AttendeeDAO().AddNewAttendee(attendee);
            return true;
        }

        public async ValueTask<List<Attendee>> SelectAll()
        {
            List<Attendee> listAttendee = await new AttendeeDAO().GetAllAttendee();
            return listAttendee;
        }

        public async ValueTask<Attendee> GetDetails(string id)
        {
            Attendee attendee = await new AttendeeDAO().GetByID(id);    
            return attendee;
        }

        public async ValueTask<bool> UpdateAttendee(Attendee newAttendee)
        {
            bool result = await new AttendeeDAO().UpdateAttendee(newAttendee);
            return result;
        }

        public async Task<bool> CheckCardIDExist(string ID)
        {
            List<Attendee> attendees= await new AttendeeDAO().GetAllAttendee();

            foreach (Attendee attendee in attendees)
                if (attendee.CardID == ID)
                    return true;

            return false;
        }
    }
}
