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
    
        public UserDAO()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("attendancerfid-a6f84");
        }

        public async ValueTask<string> CheckUser(UserLogin userLogin)
        {
            Query qref = db.Collection("User");

            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                User user = docsnap.ConvertTo<User>();
                if (docsnap.Exists)
                {
                    if (userLogin.Email == user.Email)
                    {
                        if (userLogin.Password == user.Password)
                            return "SUCCESS";                      
                        return "WRONG PASSWORD";
                    }

                }
            }
            return "USER IS NOT EXIST";
        }
    }
}
