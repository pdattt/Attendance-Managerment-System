using AttendanceManagementSystem;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoAnLapTrinhA.DAO
{
    public class AttendeeDAO
    {
        private FirestoreDb db;
        private List<Attendee> listAttendee;

        public AttendeeDAO()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("attendancerfid-a6f84");
        }

        public async ValueTask<List<Attendee>> GetAllAttendee()
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
                if (attendee.AttendeeID == id)
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
                if (attendee != null)
                {
                    try
                    {
                        if (attendee.AttendeeID == newAttendee.AttendeeID)
                        {
                            Dictionary<String, object> map = new Dictionary<String, object>()
                            {
                                {"AttendeeID", newAttendee.AttendeeID},
                                {"Name" , newAttendee.Name},
                                {"Email", newAttendee.Email},
                                {"CardID", newAttendee.CardID},
                                {"Role", newAttendee.Role}
                            };
                            await docsnap.Reference.UpdateAsync(map);
                        }
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

        public async Task<bool> DeleteAttendeeByID(string id)
        {
            Query qref = db.Collection("Attendee");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Attendee attendee = docsnap.ConvertTo<Attendee>();
                if (attendee.AttendeeID == id)
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
    }
}