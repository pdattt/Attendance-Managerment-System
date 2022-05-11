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
                listAvailableAttendee.DataSource = availableAttendees.Select(x =>x.AttendeeID + "\t\t" + x.Name + "\t" + x.Email).ToList();              
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
                string attendeeItem = listAvailableAttendee.SelectedItems[0].ToString();

                string id = attendeeItem.Substring(0, attendeeItem.IndexOf("\t"));

                Attendee attendee = availableAttendees.SingleOrDefault(att => att.AttendeeID == id);

                attendeesToJoin.Add(attendee);
                availableAttendees.Remove(attendee);


                listAvailableAttendee.DataSource = availableAttendees.Select(x => x.AttendeeID + "\t\t" + x.Name + "\t" + x.Email).ToList();
                listAttendeeToJoin.DataSource = attendeesToJoin.Select(x => x.AttendeeID + "\t\t" + x.Name + "\t" + x.Email).ToList();
            }
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            bool addCheck = new AttendeeListEventBUS().AddAttendeeToEvent(eventID, attendeesToJoin);

            if (addCheck)
            {
                MessageBox.Show("Thêm thành công!");
                attendeesToJoin = null;
            }
            else
                MessageBox.Show("Thêm thất bại!");
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
