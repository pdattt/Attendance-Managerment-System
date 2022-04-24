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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private async void btnRegist_Click(object sender, EventArgs e)
        {
            if (txtConfirmPwd.Text == txtpPwd.Text)
            {
                UserRegister newUser = new UserRegister(txtName.Text, txtEmail.Text, txtpPwd.Text);
                bool result = await new UserBUS().AddNewUser(newUser);

                if (result)
                {
                    MessageBox.Show("Tạo tài khoản thành công!");

                    this.Hide();
                    LoginForm login = new LoginForm();
                    login.Show();
                }
                else
                    MessageBox.Show("Tài khoản đã tồn tại!");
            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng!");
            }
        }

        private void txtpPw_TextChanged(object sender, EventArgs e)
        {
            txtpPwd.PasswordChar = '*';
        }

        private void txtCheckPw_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPwd.PasswordChar = '*';
        }
    }
}
