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

        public async Task<bool> DeleteClassByID(string id)
        {
            Query qref = db.Collection("Class");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Class cls = docsnap.ConvertTo<Class>();
                if (cls.ClassID.ToString() == id)
                {
                    try
                    {
                        await docsnap.Reference.DeleteAsync();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return false;
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

        public async ValueTask<bool> UpdateClass(Class newClass)
        {
            Query qref = db.Collection("Class");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Class cls = docsnap.ConvertTo<Class>();
                if (cls != null)
                {
                    try
                    {
                        if (cls.ClassID == newClass.ClassID)
                        {
                            Dictionary<String, object> map = new Dictionary<String, object>()
                            {
                                {"ClassID", newClass.ClassID},
                                {"ClassName" , newClass.ClassName},
                                {"ClassDate", newClass.ClassDate},
                                {"Location", newClass.Location},
                                {"ClassStartTime", newClass.ClassStartTime},
                                {"ClassEndTime", newClass.ClassEndTime},
                                {"ClassDateStart", newClass.ClassDateStart},
                                {"ClassDateEnd", newClass.ClassDateEnd}
                            };
                            await docsnap.Reference.UpdateAsync(map);
                        }
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }

            }
            return false;
        }

        public async ValueTask<List<Class>> SelectByKeyWord(string Name)
        {
            listClass = new List<Class>();

            Query qref = db.Collection("Class");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Class classes = docsnap.ConvertTo<Class>();
                if (classes.ClassName.Trim().ToUpper().Contains(Name.Trim().ToUpper()))
                {
                    listClass.Add(classes);
                }
            }
            return listClass;
        }
    }
}
