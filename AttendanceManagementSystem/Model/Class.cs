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
        public string ClassID { get; set; }

        [FirestoreProperty]
        public string ClassName { get; set; }

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
        public string ClassDate { get; set; }

        public Class() { }
        public Class(string classID, string className, string location, string classStartTime, string classEndTime, string classDateStart, string classDateEnd, string classDate)
        {
            ClassID = classID;
            ClassName = className;
            Location = location;
            ClassStartTime = classStartTime;
            ClassEndTime = classEndTime;
            ClassDateStart = classDateStart;
            ClassDateEnd = classDateEnd;
            ClassDate = classDate;
        }
    }
}
