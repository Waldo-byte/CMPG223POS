namespace CMPG223_POS
{
    partial class Orders
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.panelOderHome = new System.Windows.Forms.Panel();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panelDrinks = new System.Windows.Forms.Panel();
            this.panelFood = new System.Windows.Forms.Panel();
            this.btnBackDrinks = new System.Windows.Forms.Button();
            this.btnBackFood = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelOderHome.SuspendLayout();
            this.panelDrinks.SuspendLayout();
            this.panelFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1184, 32);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(77, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Orders";
            // 
            // lbOrders
            // 
            this.lbOrders.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.Location = new System.Drawing.Point(928, 32);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(256, 610);
            this.lbOrders.TabIndex = 1;
            // 
            // panelOderHome
            // 
            this.panelOderHome.Controls.Add(this.btnFood);
            this.panelOderHome.Controls.Add(this.btnDrinks);
            this.panelOderHome.Location = new System.Drawing.Point(8, 38);
            this.panelOderHome.Name = "panelOderHome";
            this.panelOderHome.Size = new System.Drawing.Size(525, 93);
            this.panelOderHome.TabIndex = 2;
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(266, 12);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(248, 68);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinks.Location = new System.Drawing.Point(12, 12);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(248, 68);
            this.btnDrinks.TabIndex = 0;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // panelDrinks
            // 
            this.panelDrinks.Controls.Add(this.btnBackDrinks);
            this.panelDrinks.Location = new System.Drawing.Point(8, 137);
            this.panelDrinks.Name = "panelDrinks";
            this.panelDrinks.Size = new System.Drawing.Size(410, 493);
            this.panelDrinks.TabIndex = 3;
            // 
            // panelFood
            // 
            this.panelFood.Controls.Add(this.btnBackFood);
            this.panelFood.Location = new System.Drawing.Point(424, 137);
            this.panelFood.Name = "panelFood";
            this.panelFood.Size = new System.Drawing.Size(498, 493);
            this.panelFood.TabIndex = 4;
            // 
            // btnBackDrinks
            // 
            this.btnBackDrinks.Location = new System.Drawing.Point(4, 3);
            this.btnBackDrinks.Name = "btnBackDrinks";
            this.btnBackDrinks.Size = new System.Drawing.Size(75, 23);
            this.btnBackDrinks.TabIndex = 0;
            this.btnBackDrinks.Text = "Back";
            this.btnBackDrinks.UseVisualStyleBackColor = true;
            this.btnBackDrinks.Click += new System.EventHandler(this.btnBackDrinks_Click);
            // 
            // btnBackFood
            // 
            this.btnBackFood.Location = new System.Drawing.Point(3, 3);
            this.btnBackFood.Name = "btnBackFood";
            this.btnBackFood.Size = new System.Drawing.Size(75, 23);
            this.btnBackFood.TabIndex = 0;
            this.btnBackFood.Text = "Back";
            this.btnBackFood.UseVisualStyleBackColor = true;
            this.btnBackFood.Click += new System.EventHandler(this.btnBackFood_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 642);
            this.Controls.Add(this.panelFood);
            this.Controls.Add(this.panelDrinks);
            this.Controls.Add(this.panelOderHome);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.panelTitle);
            this.Name = "Orders";
            this.Text = "Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelOderHome.ResumeLayout(false);
            this.panelDrinks.ResumeLayout(false);
            this.panelFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Panel panelOderHome;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panelDrinks;
        private System.Windows.Forms.Panel panelFood;
        private System.Windows.Forms.Button btnBackDrinks;
        private System.Windows.Forms.Button btnBackFood;
    }
}