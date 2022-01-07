using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleManager.gui.customcontroller;
using PeopleManager.service;
using PeopleManager.service.DAO;
using PeopleManager.gui.config;
using System.Threading;
using PeopleManager.gui.form;

namespace PeopleManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Texts))
            {
                MessageBox.Show("Thiếu tên đăng nhập!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassWord.Texts))
            {
                MessageBox.Show("Thiếu Mật khẩu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassWord.Focus();
                return;
            }
            string hashpass = PasswordHashHelper.Encrypt(txtPassWord.Texts);
            if (UserDAO.Instance.Exist(txtUsername.Texts, hashpass))
            {
                MessageBox.Show("Đăng nhập thành công");
                IniFile inifile = new IniFile(Config.configfile);
                inifile.Write("username", txtUsername.Texts);
                inifile.Write("password", hashpass);
               
                Application.Restart();
              
            }

        }
    }
}
