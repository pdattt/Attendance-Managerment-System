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
        private void AttendeeForm_Load(object sender, EventArgs e)
        {
            txtAttendeeID.Text = new AttendeeBUS().GetRandom(5);
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

    }
}
