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
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void lbl_Client_ID_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(txt_ClientID.Text == null)
            {
                MessageBox.Show("No ID provided");
            }
            else
            {
                try
                {
                    funcClass f1 = new funcClass();
                    f1.payBill(int.Parse(txt_ClientID.Text));
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
