using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CMPG223_POS
{
    public partial class Orders : Form
    {
        funcClass functions = new funcClass();
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
        }

        private void btnAfricaPilsner_Click(object sender, EventArgs e)
        {
            functions.addItem("Africa Pilsner");
        }

        private void btnWeisbeer_Click(object sender, EventArgs e)
        {
            functions.addItem("Weissbeer");
        }

        private void btnRedAle_Click(object sender, EventArgs e)
        {
            functions.addItem("Red Ale");
        }

        private void btnGRTAle_Click(object sender, EventArgs e)
        {
            functions.addItem("GRT Ale");
        }

        private void btnStout_Click(object sender, EventArgs e)
        {
            functions.addItem("Stout");
        }

        private void btnCraftGin_Click(object sender, EventArgs e)
        {
            functions.addItem("Craft Gin");
        }

        private void btnRum_Click(object sender, EventArgs e)
        {
            functions.addItem("Rum");
        }

        private void btnBeefBurger_Click(object sender, EventArgs e)
        {
            functions.addItem("Beef Burger");
        }

        private void btnChickenBurger_Click(object sender, EventArgs e)
        {
            functions.addItem("Chicken Burger");
        }

        private void btnCheeseBurger_Click(object sender, EventArgs e)
        {
            functions.addItem("Cheese Burger");
        }

        private void btnChickenSnitzel_Click(object sender, EventArgs e)
        {
            functions.addItem("Chicken Schnitzel");
        }

        private void btnSmallChips_Click(object sender, EventArgs e)
        {
            functions.addItem("Small Chips");
        }

        private void btnMediumChips_Click(object sender, EventArgs e)
        {
            functions.addItem("Medium Chips");
        }

        private void btnLargeChips_Click(object sender, EventArgs e)
        {
            functions.addItem("Large Chips");
        }

        private void btnRegularWings_Click(object sender, EventArgs e)
        {
            functions.addItem("Regular Wings");
        }

        private void btnHotWings_Click(object sender, EventArgs e)
        {
            functions.addItem("Hot Wings");
        }

        private void btnMildWings_Click(object sender, EventArgs e)
        {
            functions.addItem("Mild Wings");
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            int count = 0;
            string[] orders = new string[100]; 
            while(lbOrders.Items != null)
            {
                
                orders[count] = lbOrders.Items[count].ToString();
                
            }
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
