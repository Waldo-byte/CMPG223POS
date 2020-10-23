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

        public void buttonStyle(Control source)
        {
            foreach(Control con in source.Controls)
            {
                if (con is Button)
                {
                    Button but = con as Button;
                    but.BackColor = Color.FromArgb(225,225,225);
                    but.ForeColor = Color.FromArgb(0,0,0);
                    but.FlatStyle = FlatStyle.Flat;
                    but.FlatAppearance.BorderSize = 0;
                    but.FlatAppearance.BorderColor = Color.FromArgb(125, 125, 125);
                    but.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 100, 40);
                }
                else
                {
                    buttonStyle(con);
                }
            }
        }

        //Exit Sequence
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonStyle(panelSideBar);

            mainMenuStrip.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());

            LoginForm log = new LoginForm();
            SignUp sign = new SignUp();

            log.MdiParent = this;
            sign.MdiParent = this;

            log.Show();
            sign.Show();

            foreach (var mdi in this.Controls.OfType<MdiClient>())
            {
                mdi.BackColor = Color.FromArgb(225,225,225);
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
