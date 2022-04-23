using DoAnLapTrinhA.BUS;
using DoAnLapTrinhA.DTO;
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
        public Login()
        {
            InitializeComponent();
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
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

        public async void CheckAccount()
        {
            UserLogin userLogin = new UserLogin(txtAccount.Text, txtPassWord.Text);
            string check = await new UserBUS().CheckAccount(userLogin);

            switch (check)
            {
                case "SUCCESS":
                    {
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                        break;
                    }
                case "WRONG PASSWORD": 
                    {
                        MessageBox.Show("Mật Khẩu Không Đúng");
                        break; 
                    }
                default: 
                    {
                        MessageBox.Show("Tài Khoản Không Tồn Tại");
                        break; 
                    }
            }
        }

    }
}
