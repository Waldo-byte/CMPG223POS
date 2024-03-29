﻿namespace CMPG223_POS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnSignUpCustomer = new System.Windows.Forms.Button();
            this.bntStock = new System.Windows.Forms.Button();
            this.btnAddWaiter = new System.Windows.Forms.Button();
            this.btnBuyInventory = new System.Windows.Forms.Button();
            this.btnReportClientOrder = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panelSideBar.Controls.Add(this.btnOrders);
            this.panelSideBar.Controls.Add(this.btnSignUpCustomer);
            this.panelSideBar.Controls.Add(this.bntStock);
            this.panelSideBar.Controls.Add(this.btnAddWaiter);
            this.panelSideBar.Controls.Add(this.btnBuyInventory);
            this.panelSideBar.Controls.Add(this.btnReportClientOrder);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 24);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(200, 426);
            this.panelSideBar.TabIndex = 1;
            // 
            // btnOrders
            // 
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOrders.Location = new System.Drawing.Point(1, 1);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(198, 40);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Place New Order";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnSignUpCustomer
            // 
            this.btnSignUpCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSignUpCustomer.Location = new System.Drawing.Point(1, 42);
            this.btnSignUpCustomer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnSignUpCustomer.Name = "btnSignUpCustomer";
            this.btnSignUpCustomer.Size = new System.Drawing.Size(198, 40);
            this.btnSignUpCustomer.TabIndex = 4;
            this.btnSignUpCustomer.Text = "Sign Up Customer";
            this.btnSignUpCustomer.UseVisualStyleBackColor = true;
            this.btnSignUpCustomer.Click += new System.EventHandler(this.btnSignUpCustomer_Click);
            // 
            // bntStock
            // 
            this.bntStock.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntStock.Location = new System.Drawing.Point(1, 83);
            this.bntStock.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.bntStock.Name = "bntStock";
            this.bntStock.Size = new System.Drawing.Size(198, 40);
            this.bntStock.TabIndex = 3;
            this.bntStock.Text = "Stock";
            this.bntStock.UseVisualStyleBackColor = true;
            this.bntStock.Click += new System.EventHandler(this.bntStock_Click);
            // 
            // btnAddWaiter
            // 
            this.btnAddWaiter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddWaiter.Location = new System.Drawing.Point(1, 124);
            this.btnAddWaiter.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnAddWaiter.Name = "btnAddWaiter";
            this.btnAddWaiter.Size = new System.Drawing.Size(198, 40);
            this.btnAddWaiter.TabIndex = 1;
            this.btnAddWaiter.Text = "Add New Waiter";
            this.btnAddWaiter.UseVisualStyleBackColor = true;
            this.btnAddWaiter.Click += new System.EventHandler(this.btnAddWaiter_Click);
            // 
            // btnBuyInventory
            // 
            this.btnBuyInventory.Location = new System.Drawing.Point(1, 165);
            this.btnBuyInventory.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnBuyInventory.Name = "btnBuyInventory";
            this.btnBuyInventory.Size = new System.Drawing.Size(198, 40);
            this.btnBuyInventory.TabIndex = 5;
            this.btnBuyInventory.Text = "Buy Inventory";
            this.btnBuyInventory.UseVisualStyleBackColor = true;
            this.btnBuyInventory.Click += new System.EventHandler(this.btnBuyInventory_Click);
            // 
            // btnReportClientOrder
            // 
            this.btnReportClientOrder.Location = new System.Drawing.Point(3, 208);
            this.btnReportClientOrder.Name = "btnReportClientOrder";
            this.btnReportClientOrder.Size = new System.Drawing.Size(196, 34);
            this.btnReportClientOrder.TabIndex = 6;
            this.btnReportClientOrder.Text = "Report Client Order";
            this.btnReportClientOrder.UseVisualStyleBackColor = true;
            this.btnReportClientOrder.Click += new System.EventHandler(this.btnReportClientOrder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnAddWaiter;
        private System.Windows.Forms.Button bntStock;
        private System.Windows.Forms.Button btnSignUpCustomer;
        public System.Windows.Forms.FlowLayoutPanel panelSideBar;
        private System.Windows.Forms.Button btnBuyInventory;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnReportClientOrder;
    }
}