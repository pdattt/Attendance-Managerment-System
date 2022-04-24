using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace AttendanceManagementSystem
{
    public partial class MainForm : Form
    {
       
        FirestoreDb database;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            tryGetData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            database = FirestoreDb.Create("attendancerfid-a6f84");
        }

        async void tryGetData()
        {
            DocumentReference docref = database.Collection("Student").Document("2184503");
            DocumentSnapshot snap = await docref.GetSnapshotAsync();

            if (snap.Exists)
            {
                Student student = snap.ConvertTo<Student>();
                txtName.Text = student.Name;
                txtEmail.Text = student.Email;
                txtId.Text = student.StudentID.ToString();
            }
        }

        private void grInfo_Enter(object sender, EventArgs e)
        {
           /* string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);*/
        }
    }
}
