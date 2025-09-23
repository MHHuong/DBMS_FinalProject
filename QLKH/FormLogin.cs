using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH
{
    public partial class FormLogin : Form
    {
        private bool isLogin = true;

        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            this.CancelButton = btnExit;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()) || string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                errorProvider1.SetError(txtUsername, "Tài khoản hoặc mật khẩu không hợp lệ");
                return;
            }
            if (!isLogin)
            {
                return;
            }
            try
            {
                DBConfig.SqlConnectionString(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                DBConnect db = new DBConnect();
                db.OpenDatabase();
                this.Hide();
                this.DialogResult = DialogResult.OK;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đăng nhập thất bại. Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi kết nối đến SQL Server.\n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



       

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy liên hệ với admin", "Thông báo");
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy liên hệ với admin", "Thông báo");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
