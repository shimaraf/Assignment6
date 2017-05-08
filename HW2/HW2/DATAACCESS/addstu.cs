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
    class addstu
 
    {SqlConnection connection=new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
      public void func_addstudent(string sname, string family, string st_id, string address, string tel_No, string gender)/*,string Field_cod)*/
	
      {
          try
          {
              //parameter1
              SqlParameter _sname = new SqlParameter();
              _sname.ParameterName = "@sname";
              _sname.SqlDbType = SqlDbType.NVarChar;
              _sname.Value = sname;

              //parameter2
              SqlParameter _family = new SqlParameter();
              _family.ParameterName = "@family";
              _family.SqlDbType = SqlDbType.NVarChar;
              _family.Value = family;

              //parameter3
              SqlParameter _st_id = new SqlParameter();
              _st_id.ParameterName = "@st_id";
              _st_id.SqlDbType = SqlDbType.NVarChar;
              _st_id.Value = st_id;

              //parameter4
              SqlParameter _address = new SqlParameter();
              _address.ParameterName = "@address";
              _address.SqlDbType = SqlDbType.NVarChar;
              _address.Value = address;

              //parameter5
              SqlParameter _tel_No = new SqlParameter();
              _tel_No.ParameterName = "@tel_no";
              _tel_No.SqlDbType = SqlDbType.NVarChar;
              _tel_No.Value = tel_No;

              //parameter6
              SqlParameter _Gender = new SqlParameter();
              _Gender.ParameterName = "@Gender";
              _Gender.SqlDbType = SqlDbType.NChar;
              _Gender.Value = gender;

              //parameter7
           /*   SqlParameter _Field_cod = new SqlParameter();
              _Field_cod.ParameterName = "@Field_cod";
              _Field_cod.SqlDbType = SqlDbType.NVarChar;
              _Field_cod.Value = Field_cod;
              */

              //conection
              connection.Open();
              SqlCommand cmd = new SqlCommand();
              cmd.Connection = connection;
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.CommandText = "addstudent";

              //addparameter
              cmd.Parameters.Add(_sname);
              cmd.Parameters.Add(_family);
              cmd.Parameters.Add(_st_id);
              cmd.Parameters.Add(_address);
              cmd.Parameters.Add(_tel_No);
              cmd.Parameters.Add(_Gender);
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
