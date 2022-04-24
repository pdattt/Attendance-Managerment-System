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
    }
}
