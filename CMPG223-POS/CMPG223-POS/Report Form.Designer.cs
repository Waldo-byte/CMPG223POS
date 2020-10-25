namespace CMPG223_POS
{
    partial class ReportForm
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
            this.btnOrders = new System.Windows.Forms.Button();
            this.btClients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(55, 35);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(110, 23);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Report Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btClients
            // 
            this.btClients.Location = new System.Drawing.Point(333, 35);
            this.btClients.Name = "btClients";
            this.btClients.Size = new System.Drawing.Size(105, 23);
            this.btClients.TabIndex = 1;
            this.btClients.Text = "Report Clients";
            this.btClients.UseVisualStyleBackColor = true;
            this.btClients.Click += new System.EventHandler(this.btClients_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 358);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(581, 35);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 443);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btClients);
            this.Controls.Add(this.btnOrders);
            this.Name = "ReportForm";
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btClients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
    }
}