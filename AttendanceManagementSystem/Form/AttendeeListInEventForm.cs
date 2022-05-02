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
    public partial class AttendeeListInEvent : Form
    {
        string eventID;
        List<Attendee> attendees;

        public AttendeeListInEvent(string id)
        {
            InitializeComponent();
            eventID = id;
        }

        private async void AttendeeListInEvent_Load(object sender, EventArgs e)
        {
            attendees = await new AttendeeListEventBUS().GetAllAttendeeByEvent(eventID);
            gridAttendance.DataSource = attendees;
        }

        private void AttendeeListInEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection fcs = Application.OpenForms;

            foreach (Form form in fcs)
                if (form.Name == "EventClassManagementForm")
                    form.Enabled = true;
        }
    }
}
