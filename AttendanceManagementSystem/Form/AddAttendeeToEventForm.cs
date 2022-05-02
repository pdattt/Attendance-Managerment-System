using AttendanceManagementSystem.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagementSystem
{
    public partial class AddAttendeeToEvent : Form
    {
        string eventID;
        List<Attendee> availableAttendees;
        List<Attendee> attendeesToJoin;

        public AddAttendeeToEvent(string ID)
        {
            InitializeComponent();
            eventID = ID;
        }

        private async void AddAttendeeToEvent_Load(object sender, EventArgs e)
        {
            availableAttendees = await new AttendeeListEventBUS().GetAvailableAttendee(eventID);
            gridAvailableAttendee.DataSource = availableAttendees;
        }

        private void AddAttendeeToEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            AttendeeListInEvent attForm = new AttendeeListInEvent(eventID);
            attForm.Show();
            this.Hide();
        }
    }
}
