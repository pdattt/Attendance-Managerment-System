﻿using AttendanceManagementSystem.DAO;
using AttendanceManagementSystem.Model;
using DoAnLapTrinhA.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.BUS
{
    public class AttendeeListEventBUS
    {
        public async Task<List<Attendee>> GetAllAttendeeByEvent(string eventID)
        {
            List<Att_Eve> list = await new AttendeeListEventDAO().GetListByID(eventID);
            List<Attendee> attendees = new List<Attendee>();

            foreach(Att_Eve item in list)
            {
                Attendee attendee = await new AttendeeDAO().GetByID(item.AttendeeID);
                attendees.Add(attendee);
            }

            return attendees;
        }

        public async Task<List<Attendee>> GetAvailableAttendee(string eventID)
        {
            List<Att_Eve> list = await new AttendeeListEventDAO().GetListByID(eventID);
            List<Attendee> attendees = await new AttendeeDAO().GetAllAttendee();
            List<Attendee> availableAttendees = new List<Attendee>();
            
            foreach(Attendee item in attendees)
            {
                if (!list.Any(att => att.AttendeeID == item.AttendeeID))
                {
                    Attendee attendee = await new AttendeeDAO().GetByID(item.AttendeeID);
                    availableAttendees.Add(attendee);
                }
            }

            return availableAttendees;
            }
    }
}