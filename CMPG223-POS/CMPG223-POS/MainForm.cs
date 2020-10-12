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
                get { return Color.FromArgb(150, 150, 150); }
            }
            public override System.Drawing.Color MenuItemBorder
            {
                get { return Color.FromArgb(250, 250, 150); }
            }

            public override System.Drawing.Color MenuBorder
            {
                get { return Color.FromArgb(250, 150, 150); }
            }

            public override System.Drawing.Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(50, 50, 50); }
            }

            public override System.Drawing.Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(50, 50, 50); }
            }

            public override System.Drawing.Color MenuItemSelected
            {
                get { return Color.FromArgb(80, 80, 80); }
            }
            public override System.Drawing.Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(80, 80, 80); }
            }

            public override System.Drawing.Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(80, 80, 80); }
            }

            public override System.Drawing.Color MenuItemPressedGradientMiddle
            {
                get { return Color.FromArgb(150, 150, 150); }
            }

            public override System.Drawing.Color MenuStripGradientBegin
            {
                get { return Color.FromArgb(150, 150, 150); }
            }

            public override System.Drawing.Color MenuStripGradientEnd
            {
                get { return Color.FromArgb(150, 150, 150); }
            }

            public override System.Drawing.Color ToolStripContentPanelGradientBegin
            {
                get { return Color.FromArgb(50, 50, 50); }
            }

            public override System.Drawing.Color ToolStripContentPanelGradientEnd
            {
                get { return Color.FromArgb(50, 50, 50); }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return Color.FromArgb(50, 50, 50); }
            }

            public override Color ImageMarginGradientBegin
            {
                get { return Color.FromArgb(50, 50, 50); }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return Color.FromArgb(50, 50, 50); }
            }
            public override Color ImageMarginGradientEnd
            {
                get { return Color.FromArgb(50, 50, 50); }
            }

        }
    }
}
