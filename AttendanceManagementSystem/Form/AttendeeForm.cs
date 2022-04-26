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
            txtAttendeeID.Text = GetRandom(4);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            this.Hide();
            frm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtAttendeeID.Text = GetRandom(4);
            txtAttendeeName.Text = "";
            txtAttendeeEmail.Text = "";
            txtAttendeeCardID.Text = "";
            txtAttendeeRole.Text = "";
        }

        public string GetRandom(int lenght)
        {
            string letter = "0123456789";
            Random r = new Random((int)DateTime.Now.Ticks);

            string randomID = "WK";
            for (int i = 0; i < lenght; i++)
            {
                randomID += letter[r.Next(0, letter.Length - 1)];
            }
            return randomID;
        }

    }
}
