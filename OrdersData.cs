using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace StyroPackPro
{
    internal class OrdersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jobert\OneDrive - MSFT\Documents\StyroPACK.mdf"";Integrated Security=True;Connect Timeout=30");

        public int ID  { get; set; } 
        public string CID { get; set; }
        public string PID { get; set; }
        public string PName { get; set; }
        public string OrigPrice { get; set; }
        public string QTY { get; set; }
        public string TotalPrice { get; set; }

        public List<OrdersData> allOrdersData()
        {
            List<OrdersData> listData = new List<OrdersData>();

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                int custID = 0;
                string selectCustData = "SELECT MAX(customer_id) FROM orders";

                using (SqlCommand cmd = new SqlCommand(selectCustData, connect))
                {
                    object result = cmd.ExecuteScalar();
                    custID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }

                if (custID > 0)
                {
                    string selectData = "SELECT * FROM orders WHERE customer_id = @cID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", custID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OrdersData oData = new OrdersData();
                                
                                    oData.ID = (int)reader["id"];
                                oData.CID = reader["customer_id"].ToString();
                                oData.PID = reader["prod_id"].ToString();
                                oData.PName = reader["prod_name"].ToString();
                                oData.OrigPrice = reader["orig_price"].ToString();
                                oData.QTY = reader["qty"].ToString();
                                oData.TotalPrice = reader["total_price"].ToString();

                                    listData.Add(oData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Failed: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            return listData;
        }

    }
}

