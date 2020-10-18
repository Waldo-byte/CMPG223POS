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
            btnLogin.BackColor = Color.FromArgb(229, 241, 251);
            btnLogin.ForeColor = Color.FromArgb(7, 75, 30);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(175,175,175);
            btnLogin.FlatAppearance.BorderSize = 1;
            btnLogin.BackColor = Color.FromArgb(225,225,225);
            btnLogin.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        //GUI Design

    }
}
