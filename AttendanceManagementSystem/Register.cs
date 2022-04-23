using Google.Cloud.Firestore;
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
    public partial class Register : Form
    {
        FirestoreDb database;
        public Register()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            database = FirestoreDb.Create("attendancerfid-a6f84");
        }

        void addAccount()
        {
            if(txtCheckPw.Text == txtpPw.Text)
            {
                CollectionReference coll = database.Collection("User");
                Dictionary<string, object> map = new Dictionary<string, object>()
            {
                {"Name", txtName.Text},
                {"Email", txtEmail.Text},
                {"Password", txtpPw.Text},
            };
                coll.AddAsync(map);
                MessageBox.Show("Tài Khoản Đã Tạo Thành Công");
            }
            else
            {
                MessageBox.Show("Mật Khẩu Không Đúng, Kiểm Tra Lại");
            }
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            addAccount();
        }

        private void txtpPw_TextChanged(object sender, EventArgs e)
        {
            txtpPw.PasswordChar = '*';
        }

        private void txtCheckPw_TextChanged(object sender, EventArgs e)
        {
            txtCheckPw.PasswordChar = '*';
        }
    }
}
