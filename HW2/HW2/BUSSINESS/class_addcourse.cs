using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace HW2.BUSSINESS
{
    class class_addcourse
    {
         string Courseid;
        string Coursename;
        string Teachername;
        string  Coursetime;
        
       /* string sfield;*/
        DATAACCESS.Addtoform _addcourse = new DATAACCESS.Addtoform();
/*private   string p;
private   string p_2;
private   string p_3;
private   string p_4;*/

        public class_addcourse(string cid, string cname, string tname, string ctime)
        {
        
           Courseid=cid;
            Coursename=cname;
            Teachername=tname;
            Coursetime=ctime;
        }


        public void insertcourse()
        {
            _addcourse.func_addcourse(Courseid,Coursename,Teachername,Coursetime);
        }
    }

    }

