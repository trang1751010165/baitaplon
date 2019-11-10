﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLiQuanTraSua
{
    class connectData_class
    {
        string cnstr ;
        SqlConnection cnn;

        public void Connect()
        {
          
            if (cnn != null && cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }

        }
        public void DisConnect()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }

        }
        public DataTable Getdata(string cmd)
        {
            cnstr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLiQuanTraSua;Integrated Security=True";
            cnn = new SqlConnection(cnstr);
            try
            {

                Connect();
                SqlCommand cmds = new SqlCommand(cmd, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                DisConnect();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;

            }
        }
        public Boolean execData(string cmd)
        {
            try
            {
                Connect();
                SqlCommand cmds = new SqlCommand(cmd, cnn);
                cmds.ExecuteNonQuery();
                DisConnect();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
