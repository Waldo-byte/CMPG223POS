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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxItemId.Text == null)
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
                f1.updateStock(int.Parse(comboBoxItemId.Text),Convert.ToInt32(numUpDownStock.Value));
                f1.populateBought();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(comboBoxItemId.SelectedItem == null)
            {
                MessageBox.Show("E");
            }
            else
            {
                funcClass f1 = new funcClass();
                f1.removeStock(int.Parse(comboBoxItemId.Text));
                f1.populateBought();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxItemId.Text == null || txtDescription == null|| txtStockPrice == null || Convert.ToInt32(numUpDownStock.Value) == 0)
            {
                MessageBox.Show("E");
            }
            else
            {
                funcClass f1 = new funcClass();
                f1.addStock(int.Parse(comboBoxItemId.Text), txtDescription.Text, double.Parse(txtStockPrice.Text), Convert.ToInt32(numUpDownStock.Value));
                f1.populateBought();
            }
        }

        private void StockForm_Load(object sender, EventArgs e)
        {

        }
    }
}
