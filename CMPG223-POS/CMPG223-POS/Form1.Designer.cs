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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerLoader = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.Panel();
            this.progressLoader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerLoader
            // 
            this.timerLoader.Enabled = true;
            this.timerLoader.Interval = 1;
            this.timerLoader.Tick += new System.EventHandler(this.timerLoader_Tick);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(16)))), ((int)(((byte)(15)))));
            this.progressBar.Location = new System.Drawing.Point(0, 292);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(600, 8);
            this.progressBar.TabIndex = 0;
            // 
            // progressLoader
            // 
            this.progressLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(40)))));
            this.progressLoader.Location = new System.Drawing.Point(0, 292);
            this.progressLoader.Name = "progressLoader";
            this.progressLoader.Size = new System.Drawing.Size(3, 8);
            this.progressLoader.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(2)))), ((int)(((byte)(15)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(552, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(24)))), ((int)(((byte)(22)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.progressLoader);
            this.Controls.Add(this.progressBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerLoader;
        private System.Windows.Forms.Panel progressBar;
        private System.Windows.Forms.Panel progressLoader;
        private System.Windows.Forms.Button btnClose;
    }
}

