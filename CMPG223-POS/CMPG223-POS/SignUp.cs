using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_POS
{
    public partial class SignUp : Form
    {

        static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reyem\source\repos\Waldo-byte\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security = True";
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_MouseEnter(object sender, EventArgs e)
        {
            btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(50, 225, 120);
            btnSignUp.BackColor = Color.FromArgb(229, 251, 241);
            btnSignUp.ForeColor = Color.FromArgb(7, 75, 30);
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(175, 175, 175);
            btnSignUp.FlatAppearance.BorderSize = 1;
            btnSignUp.BackColor = Color.FromArgb(225, 225, 225);
            btnSignUp.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(225, 120, 50);
            btnCancel.BackColor = Color.FromArgb(229, 251, 241);
            btnCancel.ForeColor = Color.FromArgb(7, 75, 30);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(175, 175, 175);
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.BackColor = Color.FromArgb(225, 225, 225);
            btnCancel.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            int k;
            Exception pNumEx = new Exception();
            try
            {
                string last, first, phone;
                last = txtSurname.Text;
                first = txtName.Text;
                phone = txtPhoneNumber.Text;
                k = phone.Length;
                if (k < 10 || k > 10)
                    throw pNumEx;
                string sql_addClient = "INSERT ClientTable([LastName], [FirstName], [PhoneNumber]) VALUES(@LastName, @FirstName, @PhoneNumber)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql_addClient, conn);
                cmd.Parameters.AddWithValue("@LastName", last);
                cmd.Parameters.AddWithValue("@FirstName", first);
                cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Client: " + first + " " + last + " added.");

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please ensure phone number is 10 digits");
                txtPhoneNumber.Text = "";
            }

            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
