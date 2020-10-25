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

        static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jaden\Desktop\CMPG223 _PROJECT\New\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security=True";
        //static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASH\Source\Repos\Waldo-byte\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security=True";
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

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public void buttonStyle(Control source)
        {
            foreach (Control con in source.Controls)
            {
                if (con is Button)
                {
                    Button but = con as Button;
                    but.BackColor = Color.FromArgb(163, 58, 33);
                    but.FlatAppearance.BorderColor = Color.FromArgb(141, 51, 29);
                    but.MouseEnter += new EventHandler(this.allButton_mouseEnter);
                    but.MouseLeave += new EventHandler(this.allButton_mouseLeave);
                    but.FlatStyle = FlatStyle.Flat;
                    but.Margin = new Padding(5, 5, 5, 0);
                    but.Size = new Size(190, 40);
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
            but.FlatAppearance.MouseOverBackColor = Color.FromArgb(175, 73, 36);
            but.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 255, 200);
            but.FlatAppearance.BorderColor = Color.FromArgb(200, 102, 41);
        }

        private void allButton_mouseLeave(object sender, System.EventArgs e)
        {
            Button but = (Button)sender;
            but.FlatAppearance.BorderColor = Color.FromArgb(141, 51, 29);

        }

        public void buttonStyleItem(Control source)
        {
            foreach (Control con in source.Controls)
            {
                if (con is Button)
                {
                    Button but = con as Button;
                    but.BackColor = Color.FromArgb(163, 58, 33);
                    but.FlatAppearance.BorderColor = Color.FromArgb(141, 51, 29);
                    but.MouseEnter += new EventHandler(this.allButton2_mouseEnter);
                    but.MouseLeave += new EventHandler(this.allButton2_mouseLeave);
                    but.FlatStyle = FlatStyle.Flat;
                    but.Margin = new Padding(5, 5, 5, 0);
                    but.Size = new Size(190, 40);
                }
                else
                {
                    buttonStyle(con);
                }
            }
        }

        private void allButton2_mouseEnter(object sender, System.EventArgs e)
        {
            Button but = (Button)sender;
            but.FlatAppearance.MouseOverBackColor = Color.FromArgb(121, 63, 32);
            but.FlatAppearance.BorderColor = Color.FromArgb(200, 102, 41);
        }

        private void allButton2_mouseLeave(object sender, System.EventArgs e)
        {
            Button but = (Button)sender;
            but.FlatAppearance.BorderColor = Color.FromArgb(140, 73, 34);

        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void Orders_Load(object sender, EventArgs e)
        {
            buttonStyle(flowLayoutPanel1);
            buttonStyle(flowLayoutPanel2);
            buttonStyle(flowLayoutPanel5);

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

            panelCenter.Size = new Size(950, 350);
            panelCenter.BackColor = Color.Transparent;

            btnFood.Size = new Size(350, 0);
            btnDrinks.Size = new Size(350, 0);

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
            this.Close();
        }

        public partial class SideBarShow : UserControl
        {
            public SideBarShow()
            {

            }

            public EventHandler Ev_BTN_Pressed;

            private void btnCancelOrder_Click(Object sender, EventArgs e)
            {
                if (Ev_BTN_Pressed != null)
                {
                    Ev_BTN_Pressed(this, e);
                }
            }
        }

        private void btnSwartkatLager_Click(object sender, EventArgs e)
        {


            decimal ammount = 0;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Swartkat Lager'";
            ;
            conn.Open();
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Swartkat Lager " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnAfricaPilsner_Click(object sender, EventArgs e)
        {

            decimal ammount = 0;
            //lbOrders.Items.Add("Africa Pilsner");
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Africa Pilsner'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Africa Pilsner " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnWeisbeer_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Weissbeer");

            decimal ammount = 0;
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Weissbeer'";
            conn.Open();
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Weissbeer " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnRedAle_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Red Ale");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Red Ale'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Red Ale " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnGRTAle_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("GRT Ale");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'GRT Ale'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("GRT Ale " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnStout_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Stout");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Stout'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Stout " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnCraftGin_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Craft Gin");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Craft Gin'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Craft Gin " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnRum_Click(object sender, EventArgs e)
        {

            //lbOrders.Items.Add("Rum");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Rum'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Rum " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnBeefBurger_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Beef Burger");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Beef Burger'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Beef Burger " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnChickenBurger_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Chicken Burger");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Chicken Burger'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Chicken Burger " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnCheeseBurger_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Cheese Burger");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Cheese Burger'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Cheese Burger" + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnChickenSnitzel_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Chicken Schnitzel");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Chicken Schnitzel'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Chicken Schnitzel " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnSmallChips_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Small Chips");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Small Chips'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Small Chips " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnMediumChips_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Medium Chips");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Medium Chips'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Medium Chips " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnLargeChips_Click(object sender, EventArgs e)
        {
            lbOrders.Items.Add("Large Chips");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Large Chips'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Large Chips " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnRegularWings_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Regular Wings");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Regular Wings'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Regular Wings " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnHotWings_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Hot Wings");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Hot Wings'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Hot Wings " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnMildWings_Click(object sender, EventArgs e)
        {
            //lbOrders.Items.Add("Mild Wings");
            decimal ammount = 0;
            conn.Open();
            string sqlGet = "SELECT Price FROM Menu_Item WHERE Description = 'Mild Wings'";
            comm = new SqlCommand(sqlGet, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }

            }
            else
            {
                while (reader.Read())
                {
                    ammount = reader.GetDecimal(0);
                }
            }
            lbOrders.Items.Add("Mild Wings " + "R " + Math.Round(ammount, 2));
            cost += ammount;
            conn.Close();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            int count = 0;
            string[] orders = new string[100];
            while (lbOrders.Items != null)
            {

                orders[count] = lbOrders.Items[count].ToString();


            }

            functions.placeOrder(orders, cost, int.Parse(txtClientID.Text));
        }

        private void btnClearPreviousItemDrinks_Click(object sender, EventArgs e)
        {
            if (lbOrders.Items.Count - 1 == -1)
            {
                MessageBox.Show("E");
            }
            else
            {
                lbOrders.Items.RemoveAt((lbOrders.Items.Count - 1));
            }

        }

        private void btnClearPreviousItemFood_Click(object sender, EventArgs e)
        {

        }

        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cost.ToString());
            decimal tax = (decimal)0.15;
            PaymentForm p1 = new PaymentForm();
            p1.lblclient_id.Text = txtClientID.Text;
            p1.lblPrice.Text = cost.ToString();
            p1.lblTaxPayable.Text = (cost * tax).ToString();
            p1.Show();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmOrder_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClearPreviousItemFood_Click_1(object sender, EventArgs e)
        {
            if (lbOrders.Items.Count - 1 == -1)
            {
                MessageBox.Show("E");
            }
            else
            {
                lbOrders.Items.RemoveAt((lbOrders.Items.Count - 1));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(200,102,41);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(121, 63, 32);
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(140,73,34);
        }
    }
}
