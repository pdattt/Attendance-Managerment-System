using AttendanceManagementSystem.Model;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.DAO
{
    public class ClassDAO
    {
        FirestoreDb db;
        List<Class> listClass;

        public ClassDAO()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("attendancerfid-a6f84");
        }

        public async ValueTask<List<Class>> GetAllClass()
        {
            listClass = new List<Class>();

            Query qref = db.Collection("Class");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Class classes = docsnap.ConvertTo<Class>();
                listClass.Add(classes);
            }
            return listClass;
        }

        public bool AddNewClass(Class cls)
        {
            CollectionReference coll = db.Collection("Class");

            Dictionary<string, object> map = new Dictionary<string, object>()
            {
                {"ClassID", cls.ClassID},
                {"ClassName", cls.ClassName},
                {"ClassDate", cls.ClassDate},
                {"Location", cls.Location},
                {"ClassStartTime", cls.ClassStartTime},
                {"ClassEndTime", cls.ClassEndTime},
                {"ClassDateStart", cls.ClassDateStart},
                {"ClassDateEnd", cls.ClassDateEnd}
            };

            try {
                coll.AddAsync(map);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async ValueTask<Class> GetClassByID(string ID)
        {
            Query qref = db.Collection("Class");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Class cl = docsnap.ConvertTo<Class>();
                if (cl.ClassID == ID)
                    return cl;
            }
            return null;
        }
    }
}
