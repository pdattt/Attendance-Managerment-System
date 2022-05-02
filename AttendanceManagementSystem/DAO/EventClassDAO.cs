using AttendanceManagementSystem.Model;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.DAO
{
    public class EventClassDAO
    {
        FirestoreDb db;
        List<dynamic> listEvent;

        public EventClassDAO()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("attendancerfid-a6f84");
        }

        public async ValueTask<List<dynamic>> GetAll(string state)
        {
            listEvent = new List<dynamic>();

            Query qref = db.Collection(state);
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                dynamic events = docsnap.ConvertTo<dynamic>();
                listEvent.Add(events);
            }
            return listEvent;
        }

        public bool AddNewEvent(dynamic eve_cls, string state)
        {
            CollectionReference coll = db.Collection(state);
            Dictionary<string, object> map;

            if (state == "Event")
            {
                map = new Dictionary<string, object>()
                {
                    {"EventID", eve_cls.EventID},
                    {"EventName", eve_cls.EventName},
                    {"EventDate", eve_cls.EventDate},
                    {"Location", eve_cls.Location},
                    {"EventStartTime", eve_cls.EventStartTime},
                    {"EventEndTime", eve_cls.EventEndTime}
                };
            }
            else 
            {
                map = new Dictionary<string, object>()
                {
                    {"ClassID", eve_cls.ClassID},
                    {"ClassName", eve_cls.ClassName},
                    {"ClassDate", eve_cls.ClassDate},
                    {"Location", eve_cls.Location},
                    {"ClassStartTime", eve_cls.ClassStartTime},
                    {"ClassEndTime", eve_cls.ClassEndTime},
                    {"ClassDateStart", eve_cls.ClassDateStart},
                    {"ClassDateEnd", eve_cls.ClassDateEnd}
                };
            }

            try
            {
                coll.AddAsync(map);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteEventByID(string id, string state)
        {
            Query qref = db.Collection(state);
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                dynamic eve_cls;

                if(state == "Event")
                    eve_cls = docsnap.ConvertTo<Event>();
                else
                    eve_cls = docsnap.ConvertTo<Class>();

                if (eve_cls.EventID.ToString() == id)
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

        public async ValueTask<dynamic> GetEventByID(string id, string state)
        {
            Query qref = db.Collection(state);
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                dynamic eve_cls = docsnap.ConvertTo<dynamic>();
                if (eve_cls.EventID.ToString() == id)
                {
                    return eve_cls;
                }
            }
            return null;
        }
    }
}
