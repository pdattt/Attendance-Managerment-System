using AttendanceManagementSystem;
using DoAnLapTrinhA.DTO;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoAnLapTrinhA.DAO
{
    internal class UserDAO
    {
        private FirestoreDb db;
        private List<User> listUser;

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

        public void AddNew(UserRegister newUser)
        {
            CollectionReference coll = db.Collection("User");

            Dictionary<string, object> map = new Dictionary<string, object>()
            {
                {"Name", newUser.Name},
                {"Email", newUser.Email},
                {"Password", newUser.Password},
            };

            coll.AddAsync(map);
        }
    }
}