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
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void btnAttendee_Click(object sender, EventArgs e)
        {
            AttendeeForm attendee = new AttendeeForm();
            this.Hide();
            attendee.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            EventClassManagementForm eventclass = new EventClassManagementForm();
            this.Hide();
            eventclass.Show();
        }
    }
}