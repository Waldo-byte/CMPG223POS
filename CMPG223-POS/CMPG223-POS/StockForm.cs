using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                    but.Size = new Size((buttonContainer.Width - 36) / 5, buttonContainer.Height - 12);
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

        public int admin;

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
            dataGridViewStock.DataSource = ds;
            dataGridViewStock.DataMember = "All";

            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text.Trim() == string.Empty)
            {
                mbox.ShowMessageBox("Please enter a valid ID number to update.", "Invalid Input", "", "Error");
                mbox.ShowDialog();
            }
            else if (Convert.ToInt32(numUpDownStock.Value) == 0)
            {
                mbox.ShowMessageBox("Please enter the amount to increase by", "Invalid Input", "", "Error");
                mbox.ShowDialog();
            }
            else
            {
                funcClass f1 = new funcClass();
                f1.updateStock(int.Parse(txtItemID.Text),Convert.ToInt32(numUpDownStock.Value));
                populateBought();
                mbox.ShowMessageBox("Stock successfully updated.", "Success", "", "");
                mbox.ShowDialog();
                txtDescription.Text = "";
                txtItemID.Text = "";
                txtStockPrice.Text = "";
                numUpDownStock.Value = 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemID.Text.Trim() == string.Empty)
                {
                    mbox.ShowMessageBox("Please Enter a valid ID to delete", "Field filled error", "", "Error");
                    mbox.ShowDialog();
                }
                else if (Convert.ToInt32(txtItemID.Text) <= 0)
                {
                    mbox.ShowMessageBox("ID must be an integer value more than 0.", "Invalid Input", "", "Error");
                    mbox.ShowDialog();
                }
                else
                {
                    funcClass f1 = new funcClass();
                    f1.removeStock(int.Parse(txtItemID.Text));
                    populateBought();
                    mbox.ShowMessageBox("Stock successfully deleted.", "Sucess!", "", "");
                    mbox.ShowDialog();
                    txtDescription.Text = "";
                    txtItemID.Text = "";
                    txtStockPrice.Text = "";
                    numUpDownStock.Value = 0;
                }
            }
            catch (Exception)
            {
                mbox.ShowMessageBox("Please enter a valid integer value for ID", "Invalid Input", "", "Error");
                mbox.ShowDialog();
            }
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txtItemID.Text.Trim() == string.Empty)
                {
                    mbox.ShowMessageBox("Please ensure all text fields are filled", "Field filled error", "", "Error");
                    mbox.ShowDialog();
                }
                else if (Convert.ToInt32(txtItemID.Text) <= 0)
                {
                    mbox.ShowMessageBox("ID must be an integer value more than 0.", "Invalid Input", "", "Error");
                    mbox.ShowDialog();
                }
                else if (txtDescription.Text.Trim() == string.Empty || txtStockPrice.Text.Trim() == string.Empty)
                {
                    mbox.ShowMessageBox("Please ensure all text fields are filled", "Field filled error", "", "Error");
                    mbox.ShowDialog();
                }
                else if (Convert.ToDecimal(txtStockPrice.Text) <= 0)
                {
                    mbox.ShowMessageBox("Price must be more than 0.", "Invalid Input", "", "Error");
                    mbox.ShowDialog();
                }
                else if (Convert.ToInt32(numUpDownStock.Value) == 0)
                {
                    mbox.ShowMessageBox("Amount value cannot be 0.", "Invalid Input", "", "Error");
                    mbox.ShowDialog();
                }
                else
                {
                    funcClass f1 = new funcClass();
                    f1.addStock(int.Parse(txtItemID.Text), txtDescription.Text, double.Parse(txtStockPrice.Text), Convert.ToInt32(numUpDownStock.Value));
                    populateBought();
                    mbox.ShowMessageBox("Stock successfully added.", "Sucess!", "", "");
                    mbox.ShowDialog();
                    txtDescription.Text = "";
                    txtItemID.Text = "";
                    txtStockPrice.Text = "";
                    numUpDownStock.Value = 0;
                }
            }
            catch (Exception)
            {
                mbox.ShowMessageBox("Please enter an integer value for ID and a decimal value Price", "Invalid Input", "", "Error");
                mbox.ShowDialog();
            }
            
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            funcClass f1 = new funcClass();
            populateBought();
            buttonStyle(this);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
