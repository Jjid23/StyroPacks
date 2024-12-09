using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StyroPackPro
{
    internal class CustomersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jobert\OneDrive - MSFT\Documents\StyroPACK.mdf"";Integrated Security=True;Connect Timeout=30");

        public string CustomerID { get; set; }

        public string TotalPrice { get; set; }

        public string Amount { get; set; }

        public string Change { get; set; }

        public string Date { get; set; }

        public List<CustomersData> allTodayCustomers()
        {
            List<CustomersData> listData = new List<CustomersData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    DateTime today = DateTime.Now;
                    string selectData = "SELECT * FROM customers WHERE order_date = @date";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cmd.Parameters.AddWithValue("@date", today);
                            CustomersData cData = new CustomersData();

                            cData.CustomerID = reader["customer_id"].ToString();
                            cData.TotalPrice = reader["total_price"].ToString();
                            cData.Amount = reader["amount"].ToString();
                            cData.Change = reader["change"].ToString();
                            cData.Date = reader["order_date"].ToString();
 
                            listData.Add(cData);
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }


    }
}
