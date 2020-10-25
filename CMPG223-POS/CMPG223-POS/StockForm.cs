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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }
        public int admin;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("E");
            }
            else if (Convert.ToInt32(numUpDownStock.Value) == 0)
            {
                MessageBox.Show("E");
            }
            else
            {
                funcClass f1 = new funcClass();
                f1.updateStock(int.Parse(txtItemID.Text),Convert.ToInt32(numUpDownStock.Value));
                //f1.populateBought();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtItemID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("E");
            }
            else
            {
                funcClass f1 = new funcClass();
                f1.removeStock(int.Parse(txtItemID.Text));
                f1.populateBought();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtItemID.Text.Trim() == string.Empty || txtDescription.Text.Trim() == string.Empty || txtStockPrice.Text.Trim() == string.Empty || Convert.ToInt32(numUpDownStock.Value) == 0)
            {
                MessageBox.Show("E");
            }
            else
            {
                funcClass f1 = new funcClass();
                f1.addStock(int.Parse(txtItemID.Text), txtDescription.Text, double.Parse(txtStockPrice.Text), Convert.ToInt32(numUpDownStock.Value));
                f1.populateBought();
            }
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            funcClass f1 = new funcClass();
            f1.populateStock();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            funcClass f1 = new funcClass();
            f1.backupdb();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            funcClass f1 = new funcClass();
            f1.restoredb();
        }
    }
}
