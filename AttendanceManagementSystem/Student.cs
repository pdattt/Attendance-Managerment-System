using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace AttendanceManagementSystem
{
    [FirestoreData]
    public class Student
    {

        [FirestoreProperty]
        public int StudentID { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }
        [FirestoreProperty]
        public string CardId { get; set; }

        public Student() { }

        public Student(int studentID, string name, string email, string cardId)
        {
            StudentID = studentID;
            Name = name;
            Email = email;
            CardId = cardId;
        }
    }
}
