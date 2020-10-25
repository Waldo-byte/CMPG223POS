using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_POS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        

        void Val()
        {
            btnLogin.Enabled = !String.IsNullOrWhiteSpace(txtPassword.Text) && !String.IsNullOrWhiteSpace(txtUserName.Text);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(50, 225, 120);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 45, 24);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(229, 241, 251);
            btnLogin.ForeColor = Color.FromArgb(214, 249, 228);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(50,50,50);
            btnLogin.FlatAppearance.BorderSize = 1;
            btnLogin.ForeColor = Color.FromArgb(255,255,255);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MyMessageBox mbox = new MyMessageBox();

            funcClass f1 = new funcClass();
            int login = f1.login(txtUserName.Text, txtPassword.Text);
            if(login == 0)
            {
                mbox.ShowMessageBox("Welcome Waiter " + txtUserName.Text + "!", "Waiter Login Successful", "", "");
                mbox.ShowDialog();
                MainForm main = new MainForm();

                main.Show();
                this.Close();
            }
            else if(login == 1)
            {
                mbox.ShowMessageBox("Welcome Admin!", "Admin Login Successful", "", "");
                mbox.ShowDialog();
                MainForm main = new MainForm();

                main.Show();
                this.Close();
            }
            else
            {
                mbox.ShowMessageBox("Login Details are Invalid!\nPlease insert Correct Password and User ID!","Login Error","","Error");
                mbox.ShowDialog();
            }
        }

        //GUI Design

    }
}
