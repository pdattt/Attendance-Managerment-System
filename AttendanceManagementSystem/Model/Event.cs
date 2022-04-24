using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Model
{
    [FirestoreData]
    public class Event
    {
        [FirestoreProperty]
        public int EventID { get; set; }

        [FirestoreProperty]
        public string EventName { get; set; }

        [FirestoreProperty]
        public string EventDate { get; set; }

        [FirestoreProperty]
        public string Location { get; set; }

        [FirestoreProperty]
        public string EventStartTime { get; set; }

        [FirestoreProperty]
        public string EventEndTime { get; set; }
    }
}
