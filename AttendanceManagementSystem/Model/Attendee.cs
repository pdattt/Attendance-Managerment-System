using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace AttendanceManagementSystem
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
        public string CardId { get; set; }

        [FirestoreProperty]
        public string Role { get; set; }

        public Attendee() { }

        public Attendee(string attendeeID, string name, string email, string cardId, string role)
        {
            AttendeeID = attendeeID;
            Name = name;
            Email = email;
            CardId = cardId;
            Role = role;
        }
    }
}
