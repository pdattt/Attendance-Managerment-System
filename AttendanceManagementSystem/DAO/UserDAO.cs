using AttendanceManagementSystem;
using DoAnLapTrinhA.DTO;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTrinhA.DAO
{
    class UserDAO
    {
        FirestoreDb db;
        List<User> listUser;
    
        public UserDAO()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("attendancerfid-a6f84");
        }

        public async ValueTask<List<User>> GetAll()
        {
            listUser = new List<User>();

            Query qref = db.Collection("User");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                User user = docsnap.ConvertTo<User>();
                listUser.Add(user);
            }
            return listUser;
        }
    }
}
