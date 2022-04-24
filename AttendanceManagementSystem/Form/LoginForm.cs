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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            txtPassWord.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            this.Hide();
            register.Show();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin(txtAccount.Text, txtPassWord.Text);
            string check = await new UserBUS().CheckAccount(userLogin);

            switch (check)
            {
                case "SUCCESS":
                    {
                        this.Hide();
                        MainForm form1 = new MainForm();
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
