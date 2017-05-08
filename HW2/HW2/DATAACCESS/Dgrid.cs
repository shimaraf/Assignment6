using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace HW2.DATAACCESS
{
    class Dgrid
    {
        SqlConnection connection=new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public DataSet showdg()
        {
            DataSet ds=new DataSet();
            try
            {
                connection.Open();
                SqlDataAdapter da=new SqlDataAdapter();
                da.SelectCommand=new SqlCommand();
                da.SelectCommand.CommandText="showcourse";
                da.SelectCommand.CommandType=CommandType.StoredProcedure;
                da.SelectCommand.Connection=connection;
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(ds);
                connection.Close();
                return ds;
            }
            catch (Exception e)
            {
                connection.Close();
                MessageBox.Show(e.Message);
                return ds;
            }
        }}}
 