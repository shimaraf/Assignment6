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
    class student
    {
        string ssname;
        string sfamily;
        string stid;
        string saddress;
        string stel;
        string sgender;
       /* string sfield;*/
        DATAACCESS.addstu _addstu = new DATAACCESS.addstu();
        public student(string na, string fa, string sid, string sadd, string steln, string sgen)/*, string sfi)*/
        {
            ssname = na;
            sfamily = fa;
            stid = sid;
            saddress = sadd;
            stel = steln;
            sgender = sgen;
           /* sfield = sfi;*/
        }
        public void insertstudent()
        {
            _addstu.func_addstudent(ssname, sfamily, stid, saddress, stel, sgender);/*, sfield);*/
        }
    }
}