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
    public partial class FRMlog : Form
    {
        public FRMlog()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        FRMdtgrid _FRMdtgrid = new FRMdtgrid();
        private void buttonvord_Click(object sender, EventArgs e)
        {
             string type = " ";
            if (txtuersname.Text == "" || txtpass.Text == "")
                MessageBox.Show("لطفا نام کاربری و رمز عبور را وارد کنید");

            else
            {

              // type = _loggin.loggin(txtuersname.Text, txtpass.Text);
                

            }
            if (type != "")
            {
                MessageBox.Show("به سیستم خوش آمدید");
                txtpass.Text = txtuersname.Text = "";
                _FRMdtgrid.Show();
            }
            else
            {
                MessageBox.Show(" شما اجازه ورود به سیستم را ندارید");

                txtpass.Text = "";
            }
        }

        }
    }

