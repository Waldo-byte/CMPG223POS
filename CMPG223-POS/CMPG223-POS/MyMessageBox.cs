using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_POS
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        Button btnOk = new Button();
        Button btnCancel = new Button();
        Button btnYes = new Button();
        Button btnNo = new Button();

        //Colors---------------------------------------------------------------------------------------
        Color buttonBack;
        Color buttonBorder;
        Color buttonOverBack;
        Color buttonOverBorder;
        
        //---------------------------------------------------------------------------------------------

        //ButtonStyle----------------------------------------------------------------------------------
        public void buttonStyle(Control source)
        {
            foreach (Control con in source.Controls)
            {
                if (con is Button)
                {
                    Button but = con as Button;
                    but.BackColor = buttonBack;
                    but.FlatAppearance.BorderColor = buttonBorder;
                    but.MouseEnter += new EventHandler(this.allButton_mouseEnter);
                    but.MouseLeave += new EventHandler(this.allButton_mouseLeave);
                    but.FlatStyle = FlatStyle.Flat;
                    but.Margin = new Padding(0, 8, 8, 0);
                }
                else
                {
                    buttonStyle(con);
                }
            }
        }

        private void allButton_mouseEnter(object sender, System.EventArgs e)
        {
            Button but = (Button)sender;
            but.FlatAppearance.MouseOverBackColor = buttonOverBack;
            but.FlatAppearance.BorderColor = buttonOverBorder;
        }

        private void allButton_mouseLeave(object sender, System.EventArgs e)
        {
            Button but = (Button)sender;
            but.FlatAppearance.BorderColor = buttonOverBorder;

        }
        //---------------------------------------------------------------------------------------------
        static string Button_id;

        public void ShowMessageBox(string message, string title,string buttons, string icon)
        {
            this.Text = title;

            messageLabel.Text = message;

            if(icon == "")
            {
                iconBox.Hide();
                messageLabel.Location = new Point(10, 23);
                messageLabel.MinimumSize = new Size(180, 0);
                messageLabel.MaximumSize = new Size(180, 0);
                buttonContainer.BackColor = Color.FromArgb(153, 240, 188);
                this.BackColor = Color.FromArgb(214, 249, 228);
                buttonBack = Color.FromArgb(108, 225, 155);
                buttonBorder = Color.FromArgb(92, 208, 138);
                buttonOverBack = Color.FromArgb(75, 225, 135);
                buttonOverBorder = Color.FromArgb(50, 225, 120);
            }
            else if(icon == "Error")
            {
                iconBox.Image = Properties.Resources.error;
                messageLabel.Location = new Point(70, 23);
                messageLabel.MinimumSize = new Size(150,0);
                messageLabel.MaximumSize = new Size(150, 0);
                buttonContainer.BackColor = Color.FromArgb(255, 128, 128);
                this.BackColor = Color.FromArgb(255, 204, 204);
                buttonBack = Color.FromArgb(245, 75, 75);
                buttonBorder = Color.FromArgb(228, 58, 58);
                buttonOverBack = Color.FromArgb(248, 56, 56);
                buttonOverBorder = Color.FromArgb(255,0,0);
            }
            else if(icon == "Alert")
            {
                iconBox.Image = Properties.Resources.alert;
                messageLabel.Location = new Point(70, 23);
                messageLabel.MinimumSize = new Size(150, 0);
                messageLabel.MaximumSize = new Size(150, 0);
                buttonContainer.BackColor = Color.FromArgb(255, 228, 132);
                this.BackColor = Color.FromArgb(255, 244, 206);
                buttonBack = Color.FromArgb(245, 209, 80);
                buttonBorder = Color.FromArgb(228, 192, 64);
                buttonOverBack = Color.FromArgb(248, 207, 62);
                buttonOverBorder = Color.FromArgb(255, 201, 8);
            }
            else if(icon == "Info")
            {
                iconBox.Image = Properties.Resources.info;
                messageLabel.Location = new Point(70, 23);
                messageLabel.MinimumSize = new Size(150, 0);
                messageLabel.MaximumSize = new Size(150, 0);
                buttonContainer.BackColor = Color.FromArgb(160, 180, 216);
                this.BackColor = Color.FromArgb(217, 225, 239);
                buttonBack = Color.FromArgb(118, 144, 193);
                buttonBorder = Color.FromArgb(101, 128, 176);
                buttonOverBack = Color.FromArgb(104, 134, 189);
                buttonOverBorder = Color.FromArgb(64, 104, 177);
            }

            int width = messageLabel.Location.X * 2 + messageLabel.Width;
            int height = messageLabel.Location.Y * 2 + messageLabel.Height + buttonContainer.Height;

            this.ClientSize = new Size(width, height);

            if (buttons == "")
            {
                buttonContainer.Controls.Add(btnOk);
                btnOk.Text = "OK";

                btnOk.DialogResult = DialogResult.OK;
                btnCancel.DialogResult = DialogResult.Cancel;

                btnOk.Size = new Size((this.ClientSize.Width - 24) / 2, buttonContainer.Height - 16);

                this.AcceptButton = btnOk;
            }
            else if (buttons == "OK/Cancel")
            {
                buttonContainer.Controls.Add(btnOk);
                buttonContainer.Controls.Add(btnCancel);
                btnOk.Text = "OK";
                btnCancel.Text = "Cancel";

                btnOk.DialogResult = DialogResult.OK;
                btnCancel.DialogResult = DialogResult.Cancel;

                btnOk.Size = new Size((this.ClientSize.Width - 24) / 2, buttonContainer.Height - 16);
                btnCancel.Size = new Size((this.ClientSize.Width - 24) / 2, buttonContainer.Height - 16);

                this.AcceptButton = btnOk;

            }
            else if (buttons == "Yes/No")
            {
                buttonContainer.Controls.Add(btnYes);
                buttonContainer.Controls.Add(btnNo);
                btnYes.Text = "Yes";
                btnNo.Text = "No";

                btnYes.DialogResult = DialogResult.Yes;
                btnNo.DialogResult = DialogResult.No;

                btnYes.Size = new Size((this.ClientSize.Width - 24) / 2, buttonContainer.Height - 16);
                btnNo.Size = new Size((this.ClientSize.Width - 24) / 2, buttonContainer.Height - 16);

                this.AcceptButton = btnYes;

            }
            else if (buttons == "Yes/No/Cancel")
            {
                buttonContainer.Controls.Add(btnYes);
                buttonContainer.Controls.Add(btnNo);
                btnYes.Text = "Yes";
                btnNo.Text = "No";

                btnYes.DialogResult = DialogResult.Yes;
                btnNo.DialogResult = DialogResult.No;

                btnYes.Size = new Size((this.ClientSize.Width - 32) / 3, buttonContainer.Height - 16);
                btnNo.Size = new Size((this.ClientSize.Width - 32) / 3, buttonContainer.Height - 16);

                this.AcceptButton = btnYes;
            }

            
            
        }

        public void MessageBoxSize()
        {
            int width = messageLabel.Location.X * 2 + messageLabel.Width;
            int height = messageLabel.Location.Y * 2 + messageLabel.Height + buttonContainer.Height;

            this.ClientSize = new Size(width, height);
        }

        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            MessageBoxSize();
            buttonStyle(buttonContainer);
        }
    }
}
