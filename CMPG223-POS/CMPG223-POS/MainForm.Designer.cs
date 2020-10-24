namespace CMPG223_POS
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
            this.panelSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnAddWaiter = new System.Windows.Forms.Button();
            this.btnBuyInventory = new System.Windows.Forms.Button();
            this.bntStock = new System.Windows.Forms.Button();
            this.btnSignUpCustomer = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowsToolStripMenuItem});
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
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panelSideBar.Controls.Add(this.btnOrders);
            this.panelSideBar.Controls.Add(this.btnAddWaiter);
            this.panelSideBar.Controls.Add(this.btnBuyInventory);
            this.panelSideBar.Controls.Add(this.bntStock);
            this.panelSideBar.Controls.Add(this.btnSignUpCustomer);
            this.panelSideBar.Controls.Add(this.button5);
            this.panelSideBar.Controls.Add(this.button6);
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
            // btnAddWaiter
            // 
            this.btnAddWaiter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddWaiter.Location = new System.Drawing.Point(1, 42);
            this.btnAddWaiter.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnAddWaiter.Name = "btnAddWaiter";
            this.btnAddWaiter.Size = new System.Drawing.Size(198, 40);
            this.btnAddWaiter.TabIndex = 1;
            this.btnAddWaiter.Text = "Add New Waiter";
            this.btnAddWaiter.UseVisualStyleBackColor = true;
            // 
            // btnBuyInventory
            // 
            this.btnBuyInventory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuyInventory.Location = new System.Drawing.Point(1, 83);
            this.btnBuyInventory.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnBuyInventory.Name = "btnBuyInventory";
            this.btnBuyInventory.Size = new System.Drawing.Size(198, 40);
            this.btnBuyInventory.TabIndex = 2;
            this.btnBuyInventory.Text = "Buy Inventory";
            this.btnBuyInventory.UseVisualStyleBackColor = true;
            // 
            // bntStock
            // 
            this.bntStock.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bntStock.Location = new System.Drawing.Point(1, 124);
            this.bntStock.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.bntStock.Name = "bntStock";
            this.bntStock.Size = new System.Drawing.Size(198, 40);
            this.bntStock.TabIndex = 3;
            this.bntStock.Text = "Stock";
            this.bntStock.UseVisualStyleBackColor = true;
            // 
            // btnSignUpCustomer
            // 
            this.btnSignUpCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSignUpCustomer.Location = new System.Drawing.Point(1, 165);
            this.btnSignUpCustomer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.btnSignUpCustomer.Name = "btnSignUpCustomer";
            this.btnSignUpCustomer.Size = new System.Drawing.Size(198, 40);
            this.btnSignUpCustomer.TabIndex = 4;
            this.btnSignUpCustomer.Text = "Sign Up Customer";
            this.btnSignUpCustomer.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(1, 206);
            this.button5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(1, 247);
            this.button6.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.mainMenuStrip);
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
        private System.Windows.Forms.Button btnBuyInventory;
        private System.Windows.Forms.Button bntStock;
        private System.Windows.Forms.Button btnSignUpCustomer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.FlowLayoutPanel panelSideBar;
    }
}