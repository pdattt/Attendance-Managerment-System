﻿using AttendanceManagementSystem.Model;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.DAO
{
    public class AttendeeListEventDAO
    {
        FirestoreDb db;

        public AttendeeListEventDAO()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("attendancerfid-a6f84");
        }

        public async ValueTask<List<Att_Eve>> GetListByID(string ID)
        {
            List<Att_Eve> list = new List<Att_Eve>();
            Query qref = db.Collection("Att_Eve");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Att_Eve item = docsnap.ConvertTo<Att_Eve>();

                if(item.EventID == ID)
                    list.Add(item);
            }
            return list;
        }
    }
}
