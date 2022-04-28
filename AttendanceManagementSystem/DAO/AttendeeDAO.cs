using AttendanceManagementSystem;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTrinhA.DAO
{
    public class AttendeeDAO
    {
        FirestoreDb db;
        List<Attendee> listAttendee;

        public AttendeeDAO()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("attendancerfid-a6f84");
        }

        public async ValueTask<List<Attendee>> GetAll()
        {
            listAttendee = new List<Attendee>();

            Query qref = db.Collection("Attendee");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Attendee attendee = docsnap.ConvertTo<Attendee>();
                listAttendee.Add(attendee);
            }
            return listAttendee;
        }

        public async ValueTask<Attendee> GetByID(string id)
        {
            Query qref = db.Collection("Attendee");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Attendee attendee = docsnap.ConvertTo<Attendee>();
                if (attendee.AttendeeID.ToString() == id)
                {
                    return attendee;
                }
            }
            return null;
        }

        public void AddNewAttendee(Attendee attendee)
        {
            CollectionReference coll = db.Collection("Attendee");

            Dictionary<string, object> map = new Dictionary<string, object>()
            {
                {"AttendeeID", attendee.AttendeeID},
                {"Name", attendee.Name},
                {"Email", attendee.Email},
                {"CardID", attendee.CardID},
                {"Role", attendee.Role}
            };

            coll.AddAsync(map);
        }

        public async ValueTask<bool> UpdateAttendee(Attendee newAttendee)
        {
            Query qref = db.Collection("Attendee");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Attendee attendee = docsnap.ConvertTo<Attendee>();
                if (attendee.AttendeeID == newAttendee.AttendeeID)
                {
                    attendee.Name = newAttendee.Name;
                    attendee.Email = newAttendee.Email;
                    attendee.CardID = newAttendee.CardID;
                    attendee.Role = newAttendee.Role;
                }
            }
            return false;
        }
    }
}
