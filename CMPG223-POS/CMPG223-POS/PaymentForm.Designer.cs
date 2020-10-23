namespace CMPG223_POS
{
    partial class PaymentForm
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
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTaxPayable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(33, 158);
            this.btnPay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(94, 31);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(196, 158);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(33, 61);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(150, 25);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total of Order:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(103, 97);
            this.lblTax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(80, 20);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Tax(15%):";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(192, 62);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(60, 24);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "$$$$$";
            // 
            // lblTaxPayable
            // 
            this.lblTaxPayable.AutoSize = true;
            this.lblTaxPayable.Location = new System.Drawing.Point(192, 97);
            this.lblTaxPayable.Name = "lblTaxPayable";
            this.lblTaxPayable.Size = new System.Drawing.Size(25, 24);
            this.lblTaxPayable.TabIndex = 5;
            this.lblTaxPayable.Text = "%";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 217);
            this.Controls.Add(this.lblTaxPayable);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTaxPayable;
    }
}