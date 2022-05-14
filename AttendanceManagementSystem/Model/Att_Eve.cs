using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Model
{
    [FirestoreData]
    public class Att_Eve
    {
        [FirestoreProperty]
        public string EventID { get; set; }

        [FirestoreProperty]
        public string AttendeeID { get; set; }

        public Att_Eve()
        { }

        public Att_Eve(string eventID, string attendeeID)
        {
            EventID = eventID;
            AttendeeID = attendeeID;
        }
    }
}