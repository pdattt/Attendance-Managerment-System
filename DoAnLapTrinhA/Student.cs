using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace AttendanceManagementSystem
{
    [FirestoreData]
    internal class Student
    {
        [FirestoreProperty]
        public int StudentID { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }
    }
}
