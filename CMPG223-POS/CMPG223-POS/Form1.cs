﻿using System;
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
            progressLoader.Width += 1;
            if(progressLoader.Width >= 600)
            {
                LoginForm log = new LoginForm();
                log.Show();

                timerLoader.Stop();
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
