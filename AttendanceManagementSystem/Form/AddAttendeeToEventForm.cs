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

            attendeesToJoin = new List<Attendee>();
        }

        private async void AddAttendeeToEvent_Load(object sender, EventArgs e)
        {
            availableAttendees = await new AttendeeListEventBUS().GetAvailableAttendee(eventID);

            if (availableAttendees != null) 
            {
                listAvailableAttendee.DataSource = availableAttendees;              
            }
        }

        private void AddAttendeeToEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            AttendeeListInEvent attForm = new AttendeeListInEvent(eventID);
            attForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(availableAttendees.Count > 0)
            {
                string id = listAvailableAttendee.SelectedItems[0].ToString();

                var attendee = availableAttendees.SingleOrDefault(att => att.AttendeeID == id);

                if (attendee == null)
                    return;

                availableAttendees.RemoveAll(att => att.AttendeeID == id);
                attendeesToJoin.Add(attendee);

                gridAvailableAttendee.DataSource = availableAttendees;
                gridAttendeeToJoin.DataSource = attendeesToJoin;
            }

            Refresh();
        }
    }
}
