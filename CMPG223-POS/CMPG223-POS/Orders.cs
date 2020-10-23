using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CMPG223_POS
{
    public partial class Orders : Form
    {
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

            panelCenter.Location = new Point(this.Width / 2 - panelCenter.Width / 2, this.Height / 2 - panelCenter.Height / 2);
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
            MainForm form = (MainForm)this.Owner;

            form.panelSideBar.Show();
        }

        private void btnSwartkatLager_Click(object sender, EventArgs e)
        {
            functions.addItem("Swartkat Lager");
            cost += 30.00m;
        }

        private void btnAfricaPilsner_Click(object sender, EventArgs e)
        {
            functions.addItem("Africa Pilsner");
            cost += 30.00m;
        }

        private void btnWeisbeer_Click(object sender, EventArgs e)
        {
            functions.addItem("Weissbeer");
            cost += 30.00m;
        }

        private void btnRedAle_Click(object sender, EventArgs e)
        {
            functions.addItem("Red Ale");
            cost += 30.00m;
        }

        private void btnGRTAle_Click(object sender, EventArgs e)
        {
            functions.addItem("GRT Ale");
            cost += 30.00m;
        }

        private void btnStout_Click(object sender, EventArgs e)
        {
            functions.addItem("Stout");
            cost += 30.00m;
        }

        private void btnCraftGin_Click(object sender, EventArgs e)
        {
            functions.addItem("Craft Gin");
            cost += 45.00m;
        }

        private void btnRum_Click(object sender, EventArgs e)
        {
            functions.addItem("Rum");
            cost += 45.00m;
        }

        private void btnBeefBurger_Click(object sender, EventArgs e)
        {
            functions.addItem("Beef Burger");
            cost += 60.00m;
        }

        private void btnChickenBurger_Click(object sender, EventArgs e)
        {
            functions.addItem("Chicken Burger");
            cost += 55.00m;
        }

        private void btnCheeseBurger_Click(object sender, EventArgs e)
        {
            functions.addItem("Cheese Burger");
            cost += 65.00m;
        }

        private void btnChickenSnitzel_Click(object sender, EventArgs e)
        {
            functions.addItem("Chicken Schnitzel");
            cost += 50.00m;
        }

        private void btnSmallChips_Click(object sender, EventArgs e)
        {
            functions.addItem("Small Chips");
            cost += 30.00m;
        }

        private void btnMediumChips_Click(object sender, EventArgs e)
        {
            functions.addItem("Medium Chips");
            cost += 35.00m;
        }

        private void btnLargeChips_Click(object sender, EventArgs e)
        {
            functions.addItem("Large Chips");
            cost += 40.00m;
        }

        private void btnRegularWings_Click(object sender, EventArgs e)
        {
            functions.addItem("Regular Wings");
            cost += 80.00m;
        }

        private void btnHotWings_Click(object sender, EventArgs e)
        {
            functions.addItem("Hot Wings");
            cost += 85.00m;
        }

        private void btnMildWings_Click(object sender, EventArgs e)
        {
            functions.addItem("Mild Wings");
            cost += 80.00m;
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            int count = 0;
            string[] orders = new string[100]; 
            while(lbOrders.Items != null)
            {
                
                orders[count] = lbOrders.Items[count].ToString();

                
            }

            functions.placeOrder(orders, cost);
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
