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
    class Addtoform
    {
   
        SqlConnection connection=new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public void func_addcourse(string Course_id, string Course_name, string Teacher_name, string  TTime)
	
      {
          try
          {
              //parameter1
              SqlParameter _Courseid = new SqlParameter();
              _Courseid.ParameterName = "@Course_id";
              _Courseid.SqlDbType = SqlDbType.NVarChar;
              _Courseid.Value = Course_id;

              //parameter2
              SqlParameter _Coursename = new SqlParameter();
              _Coursename.ParameterName = "@Course_name";
              _Coursename.SqlDbType = SqlDbType.NVarChar;
              _Coursename.Value = Course_name;

              //parameter3
              SqlParameter _Teacher = new SqlParameter();
              _Teacher.ParameterName = "@Teacher_name";
              _Teacher.SqlDbType = SqlDbType.NVarChar;
              _Teacher.Value = Teacher_name;

              //parameter4
              SqlParameter _time = new SqlParameter();
              _time.ParameterName = "@TTime";
              _time.SqlDbType = SqlDbType.NVarChar;
              _time.Value = TTime;
            
              //conection
              connection.Open();
              SqlCommand cmd = new SqlCommand();
              cmd.Connection = connection;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "addcourse";

              //addparameter
              cmd.Parameters.Add(_Courseid);
              cmd.Parameters.Add(_Coursename);
              cmd.Parameters.Add(_Teacher);
              cmd.Parameters.Add(_time);
              
              /*   cmd.Parameters.Add(_Field_cod);*/

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
