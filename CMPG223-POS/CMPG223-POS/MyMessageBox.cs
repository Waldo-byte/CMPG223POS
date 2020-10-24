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
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        //Colors---------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------

        public void MessageBoxSize()
        {
            int width = messageLabel.Location.X * 2 + messageLabel.Width;
            int height = messageLabel.Location.Y * 2 + messageLabel.Height + buttonContainer.Height;

            this.ClientSize = new Size(width, height);
        }

        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            MessageBoxSize();
        }
    }
}
