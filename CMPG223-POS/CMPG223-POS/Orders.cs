using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CMPG223_POS
{
    public partial class Orders : Form
    {
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
            MainForm form = (MainForm)this.Owner;

            form.panelSideBar.Show();
        }
    }
}
