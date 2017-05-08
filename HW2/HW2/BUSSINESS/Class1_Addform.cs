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

namespace HW2.BUSSINESS
{
    class Class1_Addform
    {
         string Courseid1;
      
       
         DATAACCESS.Addform _addform = new DATAACCESS.Addform();

        public Class1_Addform(string cid1)
        {
        
           Courseid1=cid1;
          
          
        }


        public void insertform()
        {

            _addform.funcaddform(Courseid1);
        }
    }

    }

