using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Model
{
    [FirestoreData]
    public class Class
    {
        [FirestoreProperty]
        public int ClassID { get; set; }

        [FirestoreProperty]
        public string ClassName { get; set; }

        [FirestoreProperty]
        public string ClassDate { get; set; }

        [FirestoreProperty]
        public string Location { get; set; }

        [FirestoreProperty]
        public string ClassStartTime { get; set; }

        [FirestoreProperty]
        public string ClassEndTime { get; set; }

        [FirestoreProperty]
        public string ClassDateStart { get; set; }

        [FirestoreProperty]
        public string ClassDateEnd { get; set; }

        [FirestoreProperty]
        public string ClassDateInWeek { get; set; }
    }
}
