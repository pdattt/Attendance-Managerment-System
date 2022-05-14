using AttendanceManagementSystem.DAO;
using AttendanceManagementSystem.Model;
using DoAnLapTrinhA.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.BUS
{
    public class AttendeeListEventBUS
    {
        private Dictionary<string, string> dayOfWeek = new Dictionary<string, string>
        {
            { DayOfWeek.Monday.ToString(), "2" },
            { DayOfWeek.Tuesday.ToString(), "3" },
            { DayOfWeek.Wednesday.ToString(), "4" },
            { DayOfWeek.Thursday.ToString(), "5" },
            { DayOfWeek.Friday.ToString(), "6" },
            { DayOfWeek.Saturday.ToString(), "7" },
            { DayOfWeek.Sunday.ToString(), "CN" }
        };

        public ValueTask<Class> Class { get; set; }

        public async Task<List<Attendee>> GetAllAttendeeByEvent(string eventID)
        {
            List<Att_Eve> list = await new AttendeeListEventDAO().GetListByID(eventID);
            List<Attendee> attendees = new List<Attendee>();

            foreach (Att_Eve item in list)
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

            foreach (Attendee item in attendees)
            {
                if (!list.Any(att => att.AttendeeID == item.AttendeeID))
                {
                    Attendee attendee = await new AttendeeDAO().GetByID(item.AttendeeID);
                    availableAttendees.Add(attendee);
                }
            }

            return availableAttendees;
        }

        public async Task<bool> AddAttendeeToEvent(string eventID, List<Attendee> attendees)
        {
            foreach (Attendee attendee in attendees)
            {
                List<Session> sessions = await GenerateAttendanceSession(eventID, attendee.AttendeeID);

                bool addCheck = await new AttendeeListEventDAO().AddAttendee(eventID, attendee.AttendeeID);

                if (!addCheck)
                    return false;

                new AttendeeListEventDAO().AddSession(eventID, attendee.AttendeeID, sessions);
            }

            return true;
        }

        public async Task<bool> DeleteAttendeeFromEvent(string eventID, string attendeeID)
        {
            bool deleteCheck = await new AttendeeListEventDAO().DeleteAttendeeFromEvent(eventID, attendeeID);

            if (deleteCheck)
                return true;
            return false;
        }

        public async Task<List<Session>> GenerateAttendanceSession(string eventID, string attendeeID)
        {
            List<Session> sessions = new List<Session>();

            if (eventID.Substring(0, 2).ToUpper() == "CL")
            {
                Class cl = await new ClassDAO().GetClassByID(eventID);

                DateTime startDate = DateTime.Parse(cl.ClassDateStart);
                DateTime endDate = DateTime.Parse(cl.ClassDateEnd);
                List<string> classDays = cl.ClassDate.Split(',').ToList();

                for (DateTime date = startDate; date <= endDate; date = date.AddDays(1.0))
                {
                    string day = date.ToString("dddd");

                    bool checkDay = classDays.Select(d => d.Trim()).Contains(dayOfWeek[day]);

                    if (checkDay)
                    {
                        Session addSession = new Session();
                        addSession.Date = date.ToString("d");
                        addSession.DayOfWeek = date.ToString("dddd");

                        sessions.Add(addSession);
                    }
                }
            }
            else
            {
                Event eve = await new EventDAO().GetEventByID(eventID);

                Session session = new Session();
                session.Date = eve.EventDate;

                sessions.Add(session);
            }

            return sessions;
        }
    }
}