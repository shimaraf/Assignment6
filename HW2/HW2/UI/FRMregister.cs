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
    public partial class FRMregister : Form
    {
        public FRMregister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addstu_Click(object sender, EventArgs e)
        {
            BUSSINESS.student _studdent = new BUSSINESS.student(txtname.Text, txtfam.Text, txtstid.Text, txtadd.Text, txttel.Text, txtgen.Text);/*, txtfield.Text);*/
            _studdent.insertstudent();
        }

        private void txtfam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
