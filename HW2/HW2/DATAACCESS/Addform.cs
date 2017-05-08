using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace HW2.DATAACCESS
{
    class Addform
    {
   SqlConnection connection=new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public void funcaddform(string Course_id)
	
      {
          try
          {
              //parameter1
              SqlParameter _Courseid = new SqlParameter();
              _Courseid.ParameterName = "@Course_id";
              _Courseid.SqlDbType = SqlDbType.NChar;
              _Courseid.Value = Course_id;

           
            
              //conection
              connection.Open();
              SqlCommand cmd = new SqlCommand();
              cmd.Connection = connection;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "addtoform";

              //addparameter
              cmd.Parameters.Add(_Courseid);
           
           

              //exe
              cmd.ExecuteNonQuery();
              //
              connection.Close();
          }
          catch (Exception e)
          {
              connection.Close();
              MessageBox.Show(e.Message);

          }
      }

    }
}
