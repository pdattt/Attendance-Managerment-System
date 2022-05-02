using AttendanceManagementSystem.Model;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.DAO
{
    public class EventDAO
    {
        FirestoreDb db;
        List<Event> listEvent;

        public EventDAO()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("attendancerfid-a6f84");
        }

        public async ValueTask<List<Event>> GetAll()
        {
            listEvent = new List<Event>();

            Query qref = db.Collection("Event");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Event events = docsnap.ConvertTo<Event>();
                listEvent.Add(events);
            }
            return listEvent;
        }

        public bool AddNewEvent(Event e)
        {
            CollectionReference coll = db.Collection("Event");

            Dictionary<string, object> map = new Dictionary<string, object>()
            {
                {"EventID", e.EventID},
                {"EventName", e.EventName},
                {"EventDate", e.EventDate},
                {"Location", e.Location},
                {"EventStartTime", e.EventStartTime},
                {"EventEndTime", e.EventEndTime}
            };

            try {
                coll.AddAsync(map);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteEventByID(string id)
        {
            Query qref = db.Collection("Event");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Event e = docsnap.ConvertTo<Event>();
                if (e.EventID.ToString() == id)
                {
                    try
                    {
                        await docsnap.Reference.DeleteAsync();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        public async ValueTask<Event> GetEventByID(string id)
        {
            Query qref = db.Collection("Event");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Event e = docsnap.ConvertTo<Event>();
                if (e.EventID.ToString() == id)
                {
                    return e;
                }
            }
            return null;
        }
    }
}
