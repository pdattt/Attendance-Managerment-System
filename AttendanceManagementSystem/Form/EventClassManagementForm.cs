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
            txtDate.Text = DateTime.Now.Date.ToShortDateString();
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
            txtDate.Text = DateTime.Now.Date.ToShortDateString();
        }
    }
}
