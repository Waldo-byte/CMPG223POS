using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CMPG223_POS
{
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

        }

        public decimal placeOrder(String[] orders, decimal[] cost, int tableNum)
        {
            conn.Open();
            int ammount;
            decimal price;
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

            return price;  // price moet nog bereken word
        }
        public void addStock(String item)
        {

        }

        public void removeStock(String item)
        {

        }

        public void buyStock(Stock[] buyStock)

        //}

        public void payBill(int tableNum)
        {

        }

        public void clockIn(int waiaterID, String waiterPass)
        {

        }

        public void clockOut(int waiterID)
        {

        }



    }
}
