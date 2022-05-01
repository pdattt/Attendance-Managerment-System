using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceRFIDCheckIn.Model
{
    [FirestoreData]
    public class Attendee
    {
        [FirestoreProperty]
        public string AttendeeID { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }
        [FirestoreProperty]
        public int CardID { get; set; }

        [FirestoreProperty]
        public string Role { get; set; }
    }
}
