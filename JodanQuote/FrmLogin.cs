﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using loginclass;
using values;
using Connection;

namespace JodanQuote
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;

            Login login = new Login("", "");

            string user = txtUsername.Text;
            string pass = txtPassword.Text;


            if (login.IsLoggedIn(user, pass))
            {

                FrmMain form = new FrmMain();
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Log in failed please try again!");
                txtPassword.Text = "";
                this.ActiveControl = txtPassword;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btn_login.PerformClick();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {

                this.ActiveControl = txtPassword;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "Ryan";
            txtPassword.Text = "password";
            btn_login.PerformClick();
           // FrmHardwareSelect select = new FrmHardwareSelect();
            //select.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            this.ActiveControl = txtPassword;
        }
    }
}
