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
    public partial class FRMmain : Form
    {
        public FRMmain()
        {
            InitializeComponent();
        }

        private void امورپایهایToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        FRMregister _FRMregister = new FRMregister();
        private void ثبتدانشجوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FRMregister.Show();
        }
    
    //    FRMdtgrid _FRMdtgrid = new FRMdtgrid();
        FRMlog _FRMLOG = new FRMlog();
        private void انتخابواحدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FRMLOG.Show();
    //        _FRMdtgrid.Show();
        }
    }
}
