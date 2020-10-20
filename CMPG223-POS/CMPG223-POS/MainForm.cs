using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_POS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Exit Sequence
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainMenuStrip.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());

            LoginForm log = new LoginForm();
            SignUp sign = new SignUp();

            log.MdiParent = this;
            sign.MdiParent = this;

            log.Show();
            sign.Show();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(255, 255, 255);
                }
            }
        }

        //GUI
        public class CustomProfessionalColors : ProfessionalColorTable
        {

            public CustomProfessionalColors()
            {
                base.UseSystemColors = false;
            }
            public override System.Drawing.Color ToolStripBorder
            {
                get { return Color.FromArgb(225,225,225); }
            }
            public override System.Drawing.Color MenuItemBorder
            {
                get { return Color.FromArgb(0, 250, 150); }
            }

            public override System.Drawing.Color MenuBorder
            {
                get { return Color.FromArgb(0, 250, 150); }
            }

            public override System.Drawing.Color MenuItemSelected
            {
                get { return Color.FromArgb(200,255,225); }
            }
            //select menu strip
            public override System.Drawing.Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(200,255,225); }
            }

            public override System.Drawing.Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(255,255,255); }
            }

            //press menu strip
            public override System.Drawing.Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(255,255,255); }
            }

            public override System.Drawing.Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(255, 255, 255); }
            }

            public override System.Drawing.Color MenuStripGradientBegin
            {
                get { return Color.FromArgb(255,255,255); }
            }

            public override System.Drawing.Color MenuStripGradientEnd
            {
                get { return Color.FromArgb(255,255,255); }
            }

            public override System.Drawing.Color ToolStripContentPanelGradientBegin
            {
                get { return Color.FromArgb(50, 50, 50); }
            }

            public override System.Drawing.Color ToolStripContentPanelGradientEnd
            {
                get { return Color.FromArgb(255,255,255); }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return Color.FromArgb(255,255,255); }
            }

            public override Color ImageMarginGradientBegin
            {
                get { return Color.FromArgb(255,255,255); }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return Color.FromArgb(255,255,255); }
            }
            public override Color ImageMarginGradientEnd
            {
                get { return Color.FromArgb(255,255,255); }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            panelSideBar.Hide();
            Orders ord = new Orders();
            ord.MdiParent = this;
            ord.Dock = DockStyle.Fill;
            ord.Show();
        }
    }
}
