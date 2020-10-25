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
    public partial class WaiterAddForm : Form
    {
        public WaiterAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyMessageBox mbox = new MyMessageBox();
            string name = txtName.Text;
            string pass = txtPassword.Text;
            string confirm_pass = txtConfirmPassword.Text;
            if (name == string.Empty || pass == string.Empty || confirm_pass == string.Empty || txtSurname.Text == string.Empty)
            {
                mbox.ShowMessageBox("Please ensure all text fields are filled", "Field filled error", "", "Error");
                mbox.ShowDialog();
            }
            else
            {

                if (txtConfirmPassword.Text != txtPassword.Text)
                {
                    mbox.ShowMessageBox("Please ensure your passwords match", "Password match error", "", "Error");
                    mbox.ShowDialog();
                    txtConfirmPassword.Text = "";
                    txtPassword.Text = "";
                }
                else
                {
                    if (chkboxadmin.Checked)
                    {
                        try
                        {
                            funcClass f1 = new funcClass();
                            f1.addWaiter(pass, DateTime.Now.TimeOfDay, name, txtSurname.Text, 1);
                            mbox.ShowMessageBox("New waiter added (admin)", "Success!", "", "");
                            mbox.ShowDialog();
                            
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show(es.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            funcClass f1 = new funcClass();
                            f1.addWaiter(txtPassword.Text, DateTime.Now.TimeOfDay, txtName.Text, txtSurname.Text, 0);
                            mbox.ShowMessageBox("New waiter added (non-admin)", "Success!", "", "");
                            mbox.ShowDialog();
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show(es.Message);
                        }
                    }
                    txtName.Text = "";
                    txtPassword.Text = "";
                    txtSurname.Text = "";
                    txtConfirmPassword.Text = "";

                }
            }
            
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WaiterAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
