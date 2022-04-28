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
    public partial class AttendeeForm : Form
    {
        public AttendeeForm()
        {
            InitializeComponent();
        }
        private async void AttendeeForm_Load(object sender, EventArgs e)
        {
            txtAttendeeID.Text = new AttendeeBUS().GetRandom(4);
            List<Attendee> listAttendee = await new AttendeeBUS().SelectAll();
            gridAttendee.DataSource = listAttendee;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            this.Hide();
            frm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtAttendeeID.Text = new AttendeeBUS().GetRandom(5);
            txtAttendeeName.Text = "";
            txtAttendeeEmail.Text = "";
            txtAttendeeCardID.Text = "";
            txtAttendeeRole.Text = "";
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Attendee attendee = new Attendee(txtAttendeeID.Text,txtAttendeeName.Text,txtAttendeeEmail.Text,txtAttendeeCardID.Text,txtAttendeeRole.Text);
            bool result = await new AttendeeBUS().AddNewAttendee(attendee);

            if (result)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
                MessageBox.Show("Thêm thất bại!");
        }

        private async void gridAttendee_SelectionChanged(object sender, EventArgs e)
        {
            if (gridAttendee.SelectedRows.Count > 0)
            {
                string id = gridAttendee.SelectedCells[0].Value.ToString();
                Attendee attendee = await new AttendeeBUS().GetDetails(id);
                if (attendee != null)
                {
                    txtAttendeeID.Text = attendee.AttendeeID;
                    txtAttendeeName.Text = attendee.Name;
                    txtAttendeeEmail.Text = attendee.Email;
                    txtAttendeeCardID.Text = attendee.CardID;
                    txtAttendeeRole.Text = attendee.Role;
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Attendee newAttendee = new Attendee()
            {
                AttendeeID = txtAttendeeID.Text,
                Name = txtAttendeeName.Text,
                Email = txtAttendeeEmail.Text,
                CardID = txtAttendeeCardID.Text,
                Role = txtAttendeeRole.Text
            };
            bool result = await new AttendeeBUS().UpdateAttendee(newAttendee);
            if (result)
            {
                List<Attendee> listAttendee = await new AttendeeBUS().SelectAll();
                gridAttendee.DataSource = listAttendee;
            }
            else
            {
                MessageBox.Show("Có lỗi!!!!!!!!!");
            }
        }
    }
}
