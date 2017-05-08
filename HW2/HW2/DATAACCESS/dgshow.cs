using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace HW2.DATAACCESS
{
    class dgshow
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public DataSet showlistdg()
        {
            DataSet ds1 = new DataSet();
            try
            {
                connection.Open();
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = new SqlCommand();
                da1.SelectCommand.CommandText = "showform";
                da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                da1.SelectCommand.Connection = connection;
                da1.SelectCommand.ExecuteNonQuery();
                da1.Fill(ds1);
                connection.Close();
                return ds1;
            }
            catch (Exception e)
            {
                connection.Close();
                MessageBox.Show(e.Message);
                return ds1;
            }
        }
    }
}

