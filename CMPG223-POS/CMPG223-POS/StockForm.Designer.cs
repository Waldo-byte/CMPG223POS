namespace CMPG223_POS
{
    partial class StockForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.lblItemId = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtStockPrice = new System.Windows.Forms.TextBox();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.numUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.buttonContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStock)).BeginInit();
            this.buttonContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(87, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(168, 6);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(249, 6);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 8;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(0, 156);
            this.dataGridViewStock.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.Size = new System.Drawing.Size(558, 179);
            this.dataGridViewStock.TabIndex = 4;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(12, 7);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(44, 13);
            this.lblItemId.TabIndex = 6;
            this.lblItemId.Text = "Item ID:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(84, 30);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(156, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 33);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description:";
            // 
            // txtStockPrice
            // 
            this.txtStockPrice.Location = new System.Drawing.Point(84, 56);
            this.txtStockPrice.Name = "txtStockPrice";
            this.txtStockPrice.Size = new System.Drawing.Size(156, 20);
            this.txtStockPrice.TabIndex = 2;
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Location = new System.Drawing.Point(12, 59);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(34, 13);
            this.lblStockPrice.TabIndex = 10;
            this.lblStockPrice.Text = "Price:";
            // 
            // numUpDownStock
            // 
            this.numUpDownStock.BackColor = System.Drawing.SystemColors.Window;
            this.numUpDownStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDownStock.Location = new System.Drawing.Point(84, 82);
            this.numUpDownStock.Name = "numUpDownStock";
            this.numUpDownStock.Size = new System.Drawing.Size(156, 20);
            this.numUpDownStock.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 84);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Amount:";
            // 
            // btn_Restore
            // 
            this.btn_Restore.Location = new System.Drawing.Point(330, 6);
            this.btn_Restore.Margin = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(75, 23);
            this.btn_Restore.TabIndex = 7;
            this.btn_Restore.Text = "Restore";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(84, 4);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(155, 20);
            this.txtItemID.TabIndex = 0;
            // 
            // buttonContainer
            // 
            this.buttonContainer.Controls.Add(this.btnAdd);
            this.buttonContainer.Controls.Add(this.btnDelete);
            this.buttonContainer.Controls.Add(this.btnUpdate);
            this.buttonContainer.Controls.Add(this.btnBackup);
            this.buttonContainer.Controls.Add(this.btn_Restore);
            this.buttonContainer.Location = new System.Drawing.Point(0, 116);
            this.buttonContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.buttonContainer.Name = "buttonContainer";
            this.buttonContainer.Size = new System.Drawing.Size(558, 40);
            this.buttonContainer.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblItemId);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.numUpDownStock);
            this.panel1.Controls.Add(this.txtItemID);
            this.panel1.Controls.Add(this.txtStockPrice);
            this.panel1.Controls.Add(this.lblStockPrice);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 116);
            this.panel1.TabIndex = 14;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 335);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonContainer);
            this.Controls.Add(this.dataGridViewStock);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(574, 374);
            this.Name = "StockForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockForm";
            this.Load += new System.EventHandler(this.StockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStock)).EndInit();
            this.buttonContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtStockPrice;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.NumericUpDown numUpDownStock;
        private System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.FlowLayoutPanel buttonContainer;
        private System.Windows.Forms.Panel panel1;
    }
}