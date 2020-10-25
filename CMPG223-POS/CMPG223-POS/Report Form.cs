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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        public void populateOrders(string txt)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reyem\source\repos\Waldo-byte\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security = True";
            SqlConnection conn = new SqlConnection(constr);
            string sqlAll = "SELECT* FROM Client_Order WHERE Waiter_ID = '" + int.Parse(txt) + "'";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlAll, conn);
            SqlDataAdapter adap = new SqlDataAdapter();
            DataSet ds = new DataSet();

            adap.SelectCommand = comm;
            adap.Fill(ds, "All");

            BuyInventoryForm dgview = new BuyInventoryForm();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "All";

            conn.Close();
        }

        public void populateClients(string txt)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reyem\source\repos\Waldo-byte\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security = True";
            SqlConnection conn = new SqlConnection(constr);
            string sqlAll = "SELECT * FROM ClientTable WHERE FirstName ='" + txt + "'";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlAll, conn);
            SqlDataAdapter adap = new SqlDataAdapter();
            DataSet ds = new DataSet();

            adap.SelectCommand = comm;
            adap.Fill(ds, "All");

            BuyInventoryForm dgview = new BuyInventoryForm();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "All";

            conn.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            int text = 0;
            if(textBox1.Text == "")
            {
                MessageBox.Show("Please enter a search phrase");
            }
            else if(!int.TryParse(textBox1.Text,out text))
            {
                MessageBox.Show("Please enter a valid Waiter ID (integer)");
            }
            else
            {
                populateOrders(textBox1.Text);
                textBox1.Clear();
            }
            
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClients_Click(object sender, EventArgs e)
        {
            populateClients(textBox2.Text);
            textBox2.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
