using AttendanceManagementSystem.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagementSystem
{
    public partial class AttendeeForm : Form
    {
        SerialPort Port;

        public AttendeeForm()
        {
            InitializeComponent();

            Port = new SerialPort();
            Port.BaudRate = 9600;
            Port.PortName = "COM4";
            Port.Parity = Parity.None;
            Port.DataBits = 8;
            //Port.StopBits = StopBits.None;
            Port.ReadTimeout = 500;
            Port.DataReceived += Port_DataReceived;

            try
            {
                Port.Open();
                txtAttendeeCardID.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            string in_data = Port.ReadLine();
            txtAttendeeCardID.Text = in_data.Replace("\r", "");
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
            bool checkCardID = await new AttendeeBUS().CheckCardIDExist(txtAttendeeCardID.Text);

            if (checkCardID) {
                MessageBox.Show("Thẻ đã được sử dụng cho một người dùng khác!");
                return;
            }

            Attendee attendee = new Attendee(
                txtAttendeeID.Text,
                txtAttendeeName.Text,
                txtAttendeeEmail.Text,
                txtAttendeeCardID.Text,
                txtAttendeeRole.Text
                );

            bool result = await new AttendeeBUS().AddNewAttendee(attendee);

            if (result)
            {
                MessageBox.Show("Thêm thành công!");
                List<Attendee> listAttendee = await new AttendeeBUS().SelectAll();
                gridAttendee.DataSource = listAttendee;
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
                    txtAttendeeCardID.Text = attendee.CardID.ToString();
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
                MessageBox.Show("Thay Đổi Thành Công!!!!!!!!!!!");
                List<Attendee> listAttendee = await new AttendeeBUS().SelectAll();
                gridAttendee.DataSource = listAttendee;
            }
            else
            {
                MessageBox.Show("Có lỗi!!!!!!!!!");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridAttendee.SelectedRows.Count > 0)
            {
                string id = gridAttendee.SelectedCells[0].Value.ToString();
                string message = "Mã: " + id;

                var result = MessageBox.Show(message + "\nBạn có chắc chắn về việc xóa chứ?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;

                dynamic checkDelete;

                checkDelete = await new AttendeeBUS().DeleteAttendeeByID(id);
            
                if (checkDelete)
                {
                    MessageBox.Show("Xoá thành công");
                    List<Attendee> listAttendee = await new AttendeeBUS().SelectAll();
                    gridAttendee.DataSource = listAttendee;
                }
            }

            MessageBox.Show("Xóa thất bại!");
        }
    }
}
