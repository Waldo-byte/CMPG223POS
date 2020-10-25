using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_POS
{
    public partial class MainForm : Form
    {
        MyMessageBox mbox = new MyMessageBox();
        public bool admin = false;

        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void sidebarColor(Control source)
        {
            foreach (Control con in source.Controls)
            {
                if (con is FlowLayoutPanel)
                {
                    FlowLayoutPanel side = con as FlowLayoutPanel;
                    side.BackColor = Color.FromArgb(193, 72, 40);
                }
            }
        }
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
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        //Exit Sequence
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            buttonStyle(panelSideBar);
            sidebarColor(this);


            mainMenuStrip.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());

            foreach (ToolStripMenuItem item in mainMenuStrip.Items)
            {
                item.ForeColor = Color.FromArgb(200, 100, 41);
                foreach (ToolStripMenuItem children in item.DropDownItems)
                {
                    children.ForeColor = Color.FromArgb(200, 100, 41);
                }
            }

            mainMenuStrip.ForeColor = Color.FromArgb(255, 255, 255);

            foreach (var mdi in this.Controls.OfType<MdiClient>())
            {
                mdi.BackColor = Color.FromArgb(200, 100, 40);
                mdi.Dock = DockStyle.None;
                int window = GetWindowLong(mdi.Handle, GWL_EXSTYLE);
                window &= ~WS_EX_CLIENTEDGE;
                SetWindowLong(mdi.Handle, GWL_EXSTYLE, window);
                mdi.Dock = DockStyle.Fill;
            }
        }

        //GUI
        public class CustomProfessionalColors : ProfessionalColorTable
        {

            public CustomProfessionalColors() : base()
            {
                base.UseSystemColors = false;
            }

            public override System.Drawing.Color ToolStripBorder
            {
                get { return Color.FromArgb(225,225,225); }
            }
            public override System.Drawing.Color MenuItemBorder
            {
                get { return Color.FromArgb(200, 100, 41); }
            }

            public override System.Drawing.Color MenuBorder
            {
                get { return Color.FromArgb(200,100,41); }
            }

            public override System.Drawing.Color MenuItemSelected
            {
                get { return Color.FromArgb(73,40,26); }
            }
            //select menu strip
            public override System.Drawing.Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(200, 100, 40); }
            }

            public override System.Drawing.Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(41,24,22); }
            }

            //press menu strip
            public override System.Drawing.Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(200,100,40); }
            }

            public override System.Drawing.Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(41, 24, 22); }
            }

            public override System.Drawing.Color MenuStripGradientBegin
            {
                get { return Color.FromArgb(41, 24, 22); }
            }

            public override System.Drawing.Color MenuStripGradientEnd
            {
                get { return Color.FromArgb(200,100,40); }
            }

            public override System.Drawing.Color ToolStripContentPanelGradientBegin
            {
                get { return Color.FromArgb(50, 50, 50); }
            }

            public override System.Drawing.Color ToolStripContentPanelGradientEnd
            {
                get { return Color.FromArgb(41, 24, 22); }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return Color.FromArgb(41, 24, 22); }
            }

            public override Color ImageMarginGradientBegin
            {
                get { return Color.FromArgb(41, 24, 22); }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return Color.FromArgb(41,24,22); }
            }
            public override Color ImageMarginGradientEnd
            {
                get { return Color.FromArgb(41, 24, 22); }
            }
        }

        public class CustomButton : Button
        {
            private static Color _activeBorder = System.Drawing.Color.Green;

            private bool _active;
            public CustomButton() : base()
            {

            }

            protected override void OnControlAdded(ControlEventArgs e)
            {
                base.OnControlAdded(e);
                UseVisualStyleBackColor = false;
            }

            protected override void OnMouseEnter(EventArgs e)
            {
                base.OnMouseEnter(e);
                if (!_active)
                    base.FlatAppearance.BorderColor = _activeBorder;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mbox.ShowMessageBox("Are You sure you want to Exit", "Exit?", "Yes/No", "Alert");
            if (mbox.ShowDialog() == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders ord = new Orders();
            ord.MdiParent = this;
            ord.Dock = DockStyle.Fill;
            ord.Show();

            foreach (ToolStripMenuItem item in mainMenuStrip.Items)
            {
                item.ForeColor = Color.FromArgb(200, 100, 41);
                foreach (ToolStripMenuItem children in item.DropDownItems)
                {
                    children.ForeColor = Color.FromArgb(200, 100, 41);
                }
            }
        }

        private void btnAddWaiter_Click(object sender, EventArgs e)
        {
            WaiterAddForm addwaiter = new WaiterAddForm();
            addwaiter.Show();
        }

        private void bntStock_Click(object sender, EventArgs e)
        {
            StockForm stock = new StockForm();
            stock.Show();
        }

        private void btnSignUpCustomer_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
        }

        private void btnBuyInventory_Click(object sender, EventArgs e)
        {
            BuyInventoryForm buy = new BuyInventoryForm();
            buy.Show();
        }
    }
}
