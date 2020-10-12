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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Checking Push 
        }

        private void timerLoader_Tick(object sender, EventArgs e)
        {
            progressLoader.Width += 3;
            if(progressLoader.Width >= 600)
            {
                MainForm main = new MainForm();
                LoginForm log = new LoginForm();
                main.Show();
                log.Show();
                timerLoader.Stop();
                this.Hide();
            }
        }
    }
}
