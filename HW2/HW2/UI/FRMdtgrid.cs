using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW2.UI
{
    public partial class FRMdtgrid : Form
    {
        public FRMdtgrid()
        {
            InitializeComponent();
        }
        DATAACCESS.Dgrid dgclass = new DATAACCESS.Dgrid();
        private void button1_Click(object sender, EventArgs e)
        {
            dguser.DataSource = dgclass.showdg().Tables[0];

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            BUSSINESS.Class1_Addform _classaddform = new BUSSINESS.Class1_Addform(txtaddcourse.Text);
            _classaddform.insertform();
        }
        DATAACCESS.dgshow _dgshow = new DATAACCESS.dgshow();
        private void btnshowlist_Click(object sender, EventArgs e)
        {
            dguser.DataSource = _dgshow.showlistdg().Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
   
    
    }
}
