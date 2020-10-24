namespace CMPG223_POS
{
    partial class MyMessageBox
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.buttonContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(10, 23);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(150, 13);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "This is a custom Message Box";
            // 
            // buttonContainer
            // 
            this.buttonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonContainer.Location = new System.Drawing.Point(0, 350);
            this.buttonContainer.Name = "buttonContainer";
            this.buttonContainer.Size = new System.Drawing.Size(800, 100);
            this.buttonContainer.TabIndex = 1;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonContainer);
            this.Controls.Add(this.messageLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MyMessageBox";
            this.Load += new System.EventHandler(this.MyMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.FlowLayoutPanel buttonContainer;
    }
}