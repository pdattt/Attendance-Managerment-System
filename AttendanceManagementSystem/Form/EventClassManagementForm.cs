using AttendanceManagementSystem.BUS;
using AttendanceManagementSystem.Model;
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
    public partial class EventClassManagementForm : Form
    {
        public EventClassManagementForm()
        {
            InitializeComponent();
        }

        private void EventClassManagementForm_Load(object sender, EventArgs e)
        {
            labelEvent.Hide();
            labelClass.Hide();
            labelEventID.Hide();
            labelEventName.Hide();
            labelLocation.Hide();
            labelDate.Hide();
            labelStart.Hide();
            labelEnd.Hide();
            labelClassID.Hide();
            labelClassName.Hide();
            labelDateEnd.Hide();
            labelDateStart.Hide();
            labelDateInWeek.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            this.Hide();
            frm.Show();
        }

        private void radioBtnEvent_CheckedChanged(object sender, EventArgs e)
        {
            labelEvent.Show();
            labelClass.Hide();
            labelEventID.Show();
            labelEventName.Show();
            labelLocation.Show();
            labelDate.Show();
            labelStart.Show();
            labelEnd.Show();
            labelClassID.Hide();
            labelClassName.Hide();
            labelDateEnd.Hide();
            labelDateStart.Hide();
            labelDateInWeek.Hide();
            txtDateEnd.Hide();
            txtDateStart.Hide();
            txtDateInWeek.Hide();
            txtID.Text = new EventBUS().GetRandom(5);
        }

        private void radioBtnClass_CheckedChanged(object sender, EventArgs e)
        {
            labelClass.Show();
            labelEvent.Hide();
            labelEventID.Hide();
            labelEventName.Hide();
            labelLocation.Show();
            labelDate.Show();
            labelStart.Show();
            labelEnd.Show();
            labelClassID.Show();
            labelClassName.Show();
            labelDateEnd.Show();
            labelDateStart.Show();
            labelDateInWeek.Show();
            txtDateEnd.Show();
            txtDateStart.Show();
            txtDateInWeek.Show();
            txtID.Text = new ClassBUS().GetRandom(5);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (radioBtnEvent.Checked)
            {
                Event ev = new Event(txtID.Text,txtName.Text,txtDate.Text,txtLocation.Text,txtStart.Text,txtEnd.Text);
                bool result = await new EventBUS().AddEvent(ev);

                if (result)
                {
                    MessageBox.Show("Thêm thành công!");
                    List<Event> listEvent = await new EventBUS().SelectAll();
                    gridEventClass.DataSource = listEvent;
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
        }

        private async void radioBtnEvent_Click(object sender, EventArgs e)
        {
            List<Event> listEvent = await new EventBUS().SelectAll();
            gridEventClass.DataSource = listEvent;
        }
    }
}
