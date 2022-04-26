﻿using AttendanceManagementSystem.Model;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.DAO
{
    public class EventDAO
    {
        FirestoreDb db;
        List<Event> listEvent;

        public EventDAO()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("attendancerfid-a6f84");
        }

        public async ValueTask<List<Event>> GetAll()
        {
            listEvent = new List<Event>();

            Query qref = db.Collection("Event");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                Event events = docsnap.ConvertTo<Event>();
                listEvent.Add(events);
            }
            return listEvent;
        }
    }
}