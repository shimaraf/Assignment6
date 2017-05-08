# Assignment6
c# cod for university course selection
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace tamrin.dataaccess
{
    class Classdel
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
         
        public  void   del( string family)
    {
    
       try
            {
               SqlParameter _family =new SqlParameter();
               _family.ParameterName = "family";
               _family.SqlDbType = SqlDbType.NVarChar;
               _family.Value = family;

    
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "storedprocedure2";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                
                cmd.Parameters.Add(_family);
                
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            { 
                con.Close();
                MessageBox.Show(e.Message);}}}}
