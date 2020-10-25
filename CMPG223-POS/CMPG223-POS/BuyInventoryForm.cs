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
    public partial class BuyInventoryForm : Form
    {
        public BuyInventoryForm()
        {
            InitializeComponent();
        }
        MyMessageBox mbox = new MyMessageBox();
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
                    but.Size = new Size((buttonContainer.Width - 18) / 2, buttonContainer.Height - 12);
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

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" || textBox1.Text == "" || Convert.ToInt32(numUpDownItems.Value) == 0)
            {
                mbox.ShowMessageBox("Please enter a correct value for item ID or amount", "Invalid Input", "", "Error");
                mbox.ShowDialog();
            }
            else
            {
                funcClass buystock = new funcClass();
                buystock.buyStock(textBox1.Text, Convert.ToInt32(numUpDownItems.Value));
                mbox.ShowMessageBox("Stock bought successfully.", "Success", "", "");
                mbox.ShowDialog();
                textBox1.Text = "";
                numUpDownItems.Value = 0;
            }
            
        }

        public void populateBought()
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jaden\Desktop\CMPG223 _PROJECT\Main\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            string sqlAll = "SELECT * FROM Bought_Inv";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlAll, conn);
            SqlDataAdapter adap = new SqlDataAdapter();
            DataSet ds = new DataSet();

            adap.SelectCommand = comm;
            adap.Fill(ds, "All");

            BuyInventoryForm dgview = new BuyInventoryForm();
            dataGridViewItems.DataSource = ds;
            dataGridViewItems.DataMember = "All";

            conn.Close();
        }

        private void BuyInventoryForm_Load(object sender, EventArgs e)
        {
            funcClass pop = new funcClass();
            populateBought();
            buttonStyle(buttonContainer);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
