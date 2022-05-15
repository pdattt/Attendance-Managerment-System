using AttendanceManagementSystem.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AttendanceManagementSystem
{
    public partial class AddAttendeeToEvent : Form
    {
        private string eventID;
        private List<Attendee> availableAttendees;
        private List<Attendee> attendeesToJoin;

        public AddAttendeeToEvent(string ID)
        {
            InitializeComponent();
            eventID = ID;

            availableAttendees = new List<Attendee>();
            attendeesToJoin = new List<Attendee>();
        }

        public AddAttendeeToEvent(string ID, List<Attendee> attendeeToImport)
        {
            InitializeComponent();
            eventID = ID;

            availableAttendees = new List<Attendee>();
            attendeesToJoin = attendeeToImport;
        }

        private async void AddAttendeeToEvent_Load(object sender, EventArgs e)
        {
            availableAttendees = await new AttendeeListEventBUS().GetAvailableAttendee(eventID);

            if (attendeesToJoin != null)
            {
                foreach (Attendee attendee in attendeesToJoin)
                {
                    Attendee checkExistAttendee = await new AttendeeBUS().GetAttendeeByID(attendee.AttendeeID);

                    if (checkExistAttendee != null && availableAttendees.Contains(checkExistAttendee))
                        availableAttendees.Remove(attendee);
                }

                listAttendeeToJoin.DataSource = attendeesToJoin.Select(x => x.AttendeeID + "\t\t" + x.Name + "\t" + x.Email).ToList();
            }

            if (availableAttendees != null)
            {
                listAvailableAttendee.DataSource = availableAttendees.Select(x => x.AttendeeID + "\t\t" + x.Name + "\t" + x.Email).ToList();
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
            if (availableAttendees != null || availableAttendees.Count > 0)
            {
                string attendeeItem = listAvailableAttendee.SelectedItems[0].ToString();

                string id = attendeeItem.Substring(0, attendeeItem.IndexOf("\t"));

                Attendee attendee = availableAttendees.SingleOrDefault(att => att.AttendeeID == id);

                attendeesToJoin.Add(attendee);
                availableAttendees.Remove(attendee);

                listAvailableAttendee.DataSource = availableAttendees.Select(x => x.AttendeeID + "\t\t" + x.Name + "\t" + x.Email).ToList();
                listAttendeeToJoin.DataSource = attendeesToJoin.Select(x => x.AttendeeID + "\t\t" + x.Name + "\t" + x.Email).ToList();
            }
            else
                return;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (attendeesToJoin.Count > 0)
            {
                string attendeeItem = listAttendeeToJoin.SelectedItems[0].ToString();

                string id = attendeeItem.Substring(0, attendeeItem.IndexOf("\t"));

                Attendee attendee = attendeesToJoin.SingleOrDefault(att => att.AttendeeID == id);

                attendeesToJoin.Remove(attendee);
                availableAttendees.Add(attendee);

                listAvailableAttendee.DataSource = availableAttendees.Select(x => x.AttendeeID + "\t\t" + x.Name + "\t" + x.Email).ToList();
                listAttendeeToJoin.DataSource = attendeesToJoin.Select(x => x.AttendeeID + "\t\t" + x.Name + "\t" + x.Email).ToList();
            }
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            foreach (Attendee attendee in attendeesToJoin)
            {
                Attendee checkExistAttendee = await new AttendeeBUS().GetAttendeeByID(attendee.AttendeeID);

                if (checkExistAttendee == null)
                    new AttendeeBUS().AddNewAttendee(attendee);
            }

            new AttendeeListEventBUS().AddAttendeeToEvent(eventID, attendeesToJoin);

            MessageBox.Show("Thêm người tham dự thành công!");
            attendeesToJoin = null;
            listAttendeeToJoin.DataSource = attendeesToJoin;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn về việc hủy thay đổi chứ?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            AttendeeListInEvent attForm = new AttendeeListInEvent(eventID);
            attForm.Show();
            this.Hide();
        }
    }
}