using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CMPG223_POS
{
    public partial class Orders : Form
    {

        static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Waldo-byte\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        funcClass functions = new funcClass();
        decimal cost = 0.00m;

        public Orders()
        {
            InitializeComponent();
        }

        List<Panel> listPanel = new List<Panel>();
        int index;

        private void Orders_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelOderHome);
            listPanel.Add(panelDrinks);
            listPanel.Add(panelFood);

            listPanel[index].BringToFront();

            panelOderHome.Dock = DockStyle.Fill;
            panelDrinks.Dock = DockStyle.Fill;
            panelFood.Dock = DockStyle.Fill;

            this.WindowState = FormWindowState.Maximized;

            int h = ClientSize.Height;
            int w = ClientSize.Width;

            panelCenter.Location = new Point(w / 2 - panelCenter.Width / 2, h / 2 - panelCenter.Height / 2);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            labelTitle.Text = btnDrinks.Text;

            listPanel[1].BringToFront();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            labelTitle.Text = btnFood.Text;

            listPanel[2].BringToFront();
        }

        private void btnBackDrinks_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Orders";

            listPanel[0].BringToFront();
        }

        private void btnBackFood_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Orders";

            listPanel[0].BringToFront();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            //this.Close();
            FlowLayoutPanel side = (this.Parent as MainForm).Controls["panelSideBar"] as FlowLayoutPanel;

            side.Show();
        }

        private void btnSwartkatLager_Click(object sender, EventArgs e)
        {
            functions.addItem("Swartkat Lager");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Swarttkat Lager";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnAfricaPilsner_Click(object sender, EventArgs e)
        {
            functions.addItem("Africa Pilsner");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Africa Pilsner";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnWeisbeer_Click(object sender, EventArgs e)
        {
            functions.addItem("Weissbeer");

            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Weissbeer";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnRedAle_Click(object sender, EventArgs e)
        {
            functions.addItem("Red Ale");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Red Ale";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnGRTAle_Click(object sender, EventArgs e)
        {
            functions.addItem("GRT Ale");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = GRT Ale";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnStout_Click(object sender, EventArgs e)
        {
            functions.addItem("Stout");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Stout";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnCraftGin_Click(object sender, EventArgs e)
        {
            functions.addItem("Craft Gin");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Craft Gin";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnRum_Click(object sender, EventArgs e)
        {
            functions.addItem("Rum");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Rum";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnBeefBurger_Click(object sender, EventArgs e)
        {
            functions.addItem("Beef Burger");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Beef Burger";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnChickenBurger_Click(object sender, EventArgs e)
        {
            functions.addItem("Chicken Burger");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Chicken Burger";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnCheeseBurger_Click(object sender, EventArgs e)
        {
            functions.addItem("Cheese Burger");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Cheese Burger";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnChickenSnitzel_Click(object sender, EventArgs e)
        {
            functions.addItem("Chicken Schnitzel");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Chicken Schnitzel";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnSmallChips_Click(object sender, EventArgs e)
        {
            functions.addItem("Small Chips");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Small Chips";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnMediumChips_Click(object sender, EventArgs e)
        {
            functions.addItem("Medium Chips");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Medium Chips";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnLargeChips_Click(object sender, EventArgs e)
        {
            functions.addItem("Large Chips");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Large Chips";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnRegularWings_Click(object sender, EventArgs e)
        {
            functions.addItem("Regular Wings");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Regular Wings";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnHotWings_Click(object sender, EventArgs e)
        {
            functions.addItem("Hot Wings");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Hot Wings";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnMildWings_Click(object sender, EventArgs e)
        {
            functions.addItem("Mild Wings");
            int ammount;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = Mild Wings";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                int.TryParse((string)reader[0], out ammount);
            }
            else
            {
                int.TryParse((string)reader[0], out ammount);
            }
            cost += ammount;
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            int count = 0;
            string[] orders = new string[100]; 
            while(lbOrders.Items != null)
            {
                
                orders[count] = lbOrders.Items[count].ToString();

                
            }

            functions.placeOrder(orders, cost, int.Parse(txtTableNumber.Text));
        }

        private void btnClearPreviousItemDrinks_Click(object sender, EventArgs e)
        {
            lbOrders.Items[lbOrders.Items.Count - 1] = null;
        }

        private void btnClearPreviousItemFood_Click(object sender, EventArgs e)
        {
            lbOrders.Items[lbOrders.Items.Count - 1] = null;
        }
    }
}
