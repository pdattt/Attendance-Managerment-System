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
    public partial class Login : Form
    {
        FirestoreDb db;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"attendancerfid.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("attendancerfid-a6f84");
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            txtPassWord.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register regis = new Register();
            this.Hide();
            regis.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckAccount();
        }

        async void CheckAccount()
        {
            Query qref = db.Collection("User");
            QuerySnapshot snap = await qref.GetSnapshotAsync();

            foreach (DocumentSnapshot docsnap in snap)
            {
                User user = docsnap.ConvertTo<User>();
                if (docsnap.Exists)
                {
                    if (txtAccount.Text == user.Email)
                    {
                        if (txtPassWord.Text == user.Password)
                        {
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Mật Khẩu Không Đúng");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài Khoản Không Tồn Tại");
                    }
                }
            }
        }

    }
}
