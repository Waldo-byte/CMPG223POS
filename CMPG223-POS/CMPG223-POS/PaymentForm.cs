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
    public partial class PaymentForm : Form
    {
        public string clientID;
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void lbl_Client_ID_Click(object sender, EventArgs e)
        {

        }

        public void buttonStyle(Control source)
        {
            foreach (Control con in source.Controls)
            {
                if (con is Button)
                {
                    Button but = con as Button;
                    but.BackColor = Color.FromArgb(225, 225, 225);
                    but.FlatAppearance.BorderColor = Color.FromArgb(175, 175, 175);
                    but.MouseEnter += new EventHandler(this.allButton_mouseEnter);
                    but.MouseLeave += new EventHandler(this.allButton_mouseLeave);
                    but.FlatStyle = FlatStyle.Flat;
                    //but.Margin = new Padding(3, 3, 3, 0);
                    //but.Size = new Size((//buttonContainer.Width - 18) / 2, buttonContainer.Height - 12);
                }
                else
                {
                    buttonStyle(con);
                }
            }
        }

        private void allButton_mouseEnter(object sender, System.EventArgs e)
        {
            Button but = (Button)sender;
            but.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 251, 241);
            but.FlatAppearance.BorderColor = Color.FromArgb(50, 225, 120);
        }

        private void allButton_mouseLeave(object sender, System.EventArgs e)
        {
            Button but = (Button)sender;
            but.FlatAppearance.BorderColor = Color.FromArgb(175, 175, 175);

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(lblclient_id.Text == "[Client_ID]")
            {
                MessageBox.Show("No ID provided");
            }
            else
            {
                try
                {
                    funcClass f1 = new funcClass();
                    f1.payBill(int.Parse(lblclient_id.Text));
                }
                catch
                {
                    MessageBox.Show("E");
                }
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            //buttonStyle(buttonContainer);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
