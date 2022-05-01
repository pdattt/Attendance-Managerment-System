using AttendanceRFIDCheckIn.Model;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceRFIDCheckIn
{
    public class AttendeeDAO
    {
        Google.Cloud.Firestore.FirestoreDb db;

        public AttendeeDAO()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = Google.Cloud.Firestore.FirestoreDb.Create("attendancerfid-a6f84");
        }

        public async ValueTask<List<Attendee>> GetAllAttendee()
        {
            List<Attendee> attendees = new List<Attendee>();

            Query qref = db.Collection("Attendee");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Attendee attendee = docsnap.ConvertTo<Attendee>();
                attendees.Add(attendee);
            }

            return attendees;
        }
    }
}
