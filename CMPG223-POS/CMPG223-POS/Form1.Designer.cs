namespace CMPG223_POS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timerLoader = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.Panel();
            this.progressLoader = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // timerLoader
            // 
            this.timerLoader.Enabled = true;
            this.timerLoader.Interval = 15;
            this.timerLoader.Tick += new System.EventHandler(this.timerLoader_Tick);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.progressBar.Location = new System.Drawing.Point(0, 335);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(600, 15);
            this.progressBar.TabIndex = 0;
            // 
            // progressLoader
            // 
            this.progressLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.progressLoader.Location = new System.Drawing.Point(0, 335);
            this.progressLoader.Name = "progressLoader";
            this.progressLoader.Size = new System.Drawing.Size(60, 15);
            this.progressLoader.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.progressLoader);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerLoader;
        private System.Windows.Forms.Panel progressBar;
        private System.Windows.Forms.Panel progressLoader;
    }
}

