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
        public string EventID { get; set; }

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
        
        public Event()
        {

        }

        public Event(string eventID, string eventName, string eventDate, string location, string eventStartTime, string eventEndTime)
        {
            this.EventID = eventID;
            this.EventName = eventName;
            this.EventDate = eventDate;
            this.Location = location;
            this.EventStartTime = eventStartTime;
            this.EventEndTime = eventEndTime;
        }
    }
}
