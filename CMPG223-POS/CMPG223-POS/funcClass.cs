using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CMPG223_POS
{
    
    class funcClass
    {
        static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Waldo-byte\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        public void addItem(string item)
        {
            Orders orderForm = new Orders();
            orderForm.lbOrders.Items.Add(item);
        }

        public void deleteItem(string item)
        {
            Orders orderForm = new Orders();
            for (int i = 0; i < orderForm.lbOrders.Items.Count; i++)
            {
                if(orderForm.lbOrders.Items.Contains(item))
                {
                    //orderForm.lbOrders.SelectedItem =item;
                    orderForm.lbOrders.Items.Remove(item);
                }
            }
        }

        public void placeOrder(string[] orders, decimal cost, int tableNum)
        {
            conn.Open();
            int ammount;
            
            for (int i = 0; i < orders.Length; i++)
            {
                string sqlGet = "SELECT Bought_Inv FROM Menu_Item WHERE Description = '" + orders[i] + "'";
                comm = new SqlCommand(sqlGet, conn);
                adap = new SqlDataAdapter();
                ds = new DataSet();
                adap.SelectCommand = comm;
                adap.Fill(ds);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    int.TryParse((string)reader[0], out ammount);
                }
                else
                {
                    int.TryParse((string)reader[0], out ammount);
                }

                string sqlSet = "UPDATE Menu_Item SET Bought_Inv = '" + (ammount - 1) + "'" + " WHERE Inventory_ID = " + orders[i] + "'";
                comm = new SqlCommand(sqlSet, conn);
                adap = new SqlDataAdapter();
                ds = new DataSet();
                adap.SelectCommand = comm;
                adap.Fill(ds);
            }

            StreamWriter outputFile;
            outputFile = File.CreateText("Table " + tableNum);

            for(int i = 0; i < orders.Length; i++)
            {
                outputFile.WriteLine(orders[i]);
                
            }

            string sql = "UPDATE Client_Order SET Amount = '" + cost + "'";
            comm = new SqlCommand(sql, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();
            adap.SelectCommand = comm;
            adap.Fill(ds);


        }
        public void addStock(int item, string description, double price, int qty)
        {
            try
            {

                string sql_addstock = "INSERT INTO Bought_Inv ([Inventory_ID], [Description], [Price], [Quantity]) VALUES(@Item_ID, @Description, @Price, @Qty)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql_addstock, conn);
                cmd.Parameters.AddWithValue("@Item_ID", item);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Qty", qty);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
                conn.Close();
            }
            
        }

        public void removeStock(int item)
        {
            try
            {
                string sql_delstock = "DELETE FROM Bought_Inv Where [Inventory_ID] = @Item_ID";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql_delstock, conn);
                cmd.Parameters.AddWithValue("@Item_ID", item);
                cmd.ExecuteNonQuery();
                conn.Close();
                
            }

            catch(SqlException deleteEr)
            {
                MessageBox.Show(deleteEr.Message);
                conn.Close();
            }
            
        }

        public void buyStock(string item, int qty) 
        {
            try
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                StreamWriter outputfile = new StreamWriter(Path.Combine(docPath, "BuyStock.txt"));
                using (outputfile)
                {
                    outputfile.WriteLine("" + item + " " + qty); 
                }
            }

            catch
            {
                MessageBox.Show("E");
            }
            



        }
        
        public void populateStock()
        {
            string sqlAll = "SELECT * FROM Bought_Inv";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlAll, conn);
            SqlDataAdapter adap = new SqlDataAdapter();
            DataSet ds = new DataSet();

            adap.SelectCommand = comm;
            adap.Fill(ds, "All");

            StockForm dgview = new StockForm();
            dgview.dataGridViewStock.DataSource = ds;
            dgview.dataGridViewStock.DataMember = "All";

            conn.Close();

        }

        public void populateBought()
        {
            string sqlAll = "SELECT * FROM Bought_Inv";
            conn.Open();
            SqlCommand comm = new SqlCommand(sqlAll, conn);
            SqlDataAdapter adap = new SqlDataAdapter();
            DataSet ds = new DataSet();

            adap.SelectCommand = comm;
            adap.Fill(ds, "All");

            BuyInventoryForm dgview = new BuyInventoryForm();
            dgview.dataGridViewItems.DataSource = ds;
            dgview.dataGridViewItems.DataMember = "All";

            conn.Close();

        }

        public void payBill(int client_ID)
        {
            //string sqlAll = "INSERT INTO Verified Where Client_ID = '" + client_ID + "'";
            string sql_Verified = "INSERT INTO Verification([Description]) VALUES(@Description)";
            conn.Open();
            string verified = "VERIFIED";
            SqlCommand verify= new SqlCommand(sql_Verified, conn);
            verify.Parameters.AddWithValue("@Description", verified);
            verify.ExecuteNonQuery();
            conn.Close();
         

        }
        
        public void updateStock(int iD, int amnt)
        {
            int amount = 0;
            try
            {
                string sql_getamnt = "UPDATE SELECT Amount FROM Bought_Inv Where Inventory_ID = '" + iD + "'";
                string sql_update = "UPDATE Bought_Inventory([Quantity]) WHERE Inventory_ID = '" + iD + "' AND VALUES(@qty)";
                conn.Open();
                SqlCommand getamnt = new SqlCommand(sql_getamnt, conn);
                SqlDataReader datread = getamnt.ExecuteReader();
                if(datread.HasRows)
                {
                    while(datread.Read())
                    {
                       amount = datread.GetInt32(0);
                    }
                }
                else if(amount == 0)
                {
                    SqlCommand cmd = new SqlCommand(sql_update, conn);
                    cmd.Parameters.AddWithValue("@qty", amnt + amount);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("E");
                    conn.Close();
                }
                
            }
            catch(SqlException err)
            {
                MessageBox.Show(err.Message);

            }
           
        }

       // public void clockIn(int waiaterID, string waiterPass)
        //{
                
        //}

        public void clockOut(int waiterID)
        {

        }



    }
}
