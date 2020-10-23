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
    public partial class WaiterAddForm : Form
    {

        static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Waldo-byte\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        public WaiterAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == txtConfirmPassword.Text)
            {
                string sql = @"INSERT INTO Waiter (Password, FirstName, LastName) VALUES ('" + txtPassword.Text + "', '" + txtName.Text + "', '" + txtSurname.Text + "'";

                comm = new SqlCommand(sql, conn);
                adap = new SqlDataAdapter();
                ds = new DataSet();

                adap.SelectCommand = comm;
                adap.Fill(ds);
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
