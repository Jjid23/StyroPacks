﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StyroPackPro
{
    class UsersData
    {
        public int ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
        public string Date { set; get; }
        public List<UsersData> AllUsersData()
        {
            List<UsersData> listData = new List<UsersData>();


            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Jobert\OneDrive - MSFT\Documents\StyroPACK.mdf"";Integrated Security=True;Connect Timeout=30");

            {
                connect.Open();

                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UsersData uData = new UsersData();
                        uData.ID = (int)reader["id"];
                        uData.Username = reader["username"].ToString();
                        uData.Password = reader["password"].ToString();
                        uData.Role = reader["role"].ToString();
                        uData.Date = reader["date"].ToString();

                        listData.Add(uData);


                    }

                }
            }
            return listData;
        }
    }
}


        
    


