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
    public partial class BuyInventoryForm : Form
    {
        public BuyInventoryForm()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            funcClass buystock = new funcClass();
            buystock.buyStock(comboBoxItems.SelectedItem.ToString(),Convert.ToInt32(numUpDownItems.Value));
        }

        private void BuyInventoryForm_Load(object sender, EventArgs e)
        {
            funcClass pop = new funcClass();
            pop.populateBought();
        }
    }
}
