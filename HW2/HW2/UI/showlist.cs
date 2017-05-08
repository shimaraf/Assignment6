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
    public partial class showlistdg : Form
    {
        public showlistdg()
        {
            InitializeComponent();
        }

        private void dguser1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showlistdg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Course' table. You can move, or remove it, as needed.
           // this.courseTableAdapter.Fill(this.database1DataSet.Course);

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
