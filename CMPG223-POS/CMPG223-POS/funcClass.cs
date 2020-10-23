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
    //Janus was hier
    class funcClass
    {
        static String constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Waldo-byte\CMPG223-POS\CMPG223-POS\CMPG223-POS\Route96.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        public void addItem(String item)
        {
            Orders orderForm = new Orders();
            orderForm.lbOrders.Items.Add(item);
        }

        public void deleteItem(String item)
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

        public decimal placeOrder(String[] orders, decimal[] cost, int tableNum)
        {
            conn.Open();
            int ammount;
            decimal price = 0;
            for (int i = 0; i < orders.Length; i++)
            {
                String sqlGet = "SELECT Bought_Inv FROM Menu_Item WHERE Inventory_ID = '" + orders[i] + "'";
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

                String sqlSet = "UPDATE Menu_Item SET Bought_Inv = '" + (ammount - 1) + "'" + " WHERE Inventory_ID = " + orders[i] + "'";
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
                price += cost[i];
            }

            return price;  // price moet nog bereken word
        }
        public void addStock(int item, String description, double price, int qty)
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

        public void removeStock(int item, string description, double price)
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

        //public void buyStock(Stock[] buyStock)

        //}

        //public void payBill(int tableNum)
        //{

        //}

       // public void clockIn(int waiaterID, String waiterPass)
        //{

        //}

        public void clockOut(int waiterID)
        {

        }



    }
}
