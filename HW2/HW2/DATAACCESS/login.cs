 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HW2.UI
{
    class login
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlDataReader dr;
        public string loggin(string stid, string pass)
        {
            string type = "";
            try
            {
                SqlParameter _stid= new SqlParameter();
               _stid.ParameterName = "@st_id";
                _stid.SqlDbType = SqlDbType.NVarChar;
                _stid.Value = _stid;

                SqlParameter _pass = new SqlParameter();
                _pass.ParameterName = "@pass";
                _pass.SqlDbType = SqlDbType.NVarChar;
                _pass.Value = pass;

                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "LOGstu";

                cmd.Parameters.Add(_stid);
                cmd.Parameters.Add(_pass);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    type = dr["type"].ToString();
                }
                dr.Close();
                connection.Close();
                return type;
            }
            catch (Exception error)
            {
                dr.Close();
                connection.Close();
                MessageBox.Show(error.Message);
                return type;

            }
        }
    }
}
 
 
