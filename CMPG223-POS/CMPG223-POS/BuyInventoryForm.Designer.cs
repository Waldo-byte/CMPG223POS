namespace CMPG223_POS
{
    partial class BuyInventoryForm
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
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.numUpDownItems = new System.Windows.Forms.NumericUpDown();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.buttonContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownItems)).BeginInit();
            this.buttonContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(6, 6);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 0);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(77, 35);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(89, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 140);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(518, 150);
            this.dataGridViewItems.TabIndex = 2;
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(58, 5);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItems.TabIndex = 3;
            // 
            // numUpDownItems
            // 
            this.numUpDownItems.Location = new System.Drawing.Point(58, 32);
            this.numUpDownItems.Name = "numUpDownItems";
            this.numUpDownItems.Size = new System.Drawing.Size(120, 20);
            this.numUpDownItems.TabIndex = 4;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(3, 8);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 13);
            this.lblItem.TabIndex = 5;
            this.lblItem.Text = "Item:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(3, 34);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // buttonContainer
            // 
            this.buttonContainer.Controls.Add(this.btnBuy);
            this.buttonContainer.Controls.Add(this.btnCancel);
            this.buttonContainer.Location = new System.Drawing.Point(0, 100);
            this.buttonContainer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonContainer.Name = "buttonContainer";
            this.buttonContainer.Size = new System.Drawing.Size(518, 40);
            this.buttonContainer.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblItem);
            this.panel1.Controls.Add(this.comboBoxItems);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.numUpDownItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 100);
            this.panel1.TabIndex = 8;
            // 
            // BuyInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonContainer);
            this.Controls.Add(this.dataGridViewItems);
            this.MinimizeBox = false;
            this.Name = "BuyInventoryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyInventoryForm";
            this.Load += new System.EventHandler(this.BuyInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownItems)).EndInit();
            this.buttonContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblQuantity;
        public System.Windows.Forms.ComboBox comboBoxItems;
        public System.Windows.Forms.NumericUpDown numUpDownItems;
        public System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.FlowLayoutPanel buttonContainer;
        private System.Windows.Forms.Panel panel1;
    }
}