using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_POS
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }
        public int admin;
        static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reyem\source\repos\Waldo-byte\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security=True";

        SqlConnection conn = new SqlConnection(constr);
        public void populateStock()
        {
            string sqlAll = "SELECT * FROM Bought_Inv";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlAll, conn);
            SqlDataAdapter adap = new SqlDataAdapter();
            DataSet ds = new DataSet();

            adap.SelectCommand = comm;
            adap.Fill(ds, "All");

            //StockForm dgview = new StockForm();
            dataGridViewStock.DataSource = ds;
            dataGridViewStock.DataMember = "All";

            conn.Close();

        }

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
                populateStock();
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
                populateStock();
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
                populateStock();
            }
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            funcClass f1 = new funcClass();
            populateStock();
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
