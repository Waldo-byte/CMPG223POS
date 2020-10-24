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

        }
    }
}
