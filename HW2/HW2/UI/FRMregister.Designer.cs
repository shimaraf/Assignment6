namespace HW2.UI
{
    partial class FRMregister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfield = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addstu = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(299, 33);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(115, 20);
            this.txtname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "نام";
            // 
            // txtgen
            // 
            this.txtgen.Location = new System.Drawing.Point(39, 78);
            this.txtgen.Name = "txtgen";
            this.txtgen.Size = new System.Drawing.Size(122, 20);
            this.txtgen.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "جنسیت";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(40, 33);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(122, 20);
            this.txttel.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "شماره تماس";
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(39, 157);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(375, 20);
            this.txtadd.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "آدرس";
            // 
            // txtstid
            // 
            this.txtstid.Location = new System.Drawing.Point(299, 115);
            this.txtstid.Name = "txtstid";
            this.txtstid.Size = new System.Drawing.Size(115, 20);
            this.txtstid.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "شماره دانشجویی";
            // 
            // txtfam
            // 
            this.txtfam.Location = new System.Drawing.Point(299, 74);
            this.txtfam.Name = "txtfam";
            this.txtfam.Size = new System.Drawing.Size(115, 20);
            this.txtfam.TabIndex = 19;
            this.txtfam.TextChanged += new System.EventHandler(this.txtfam_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "نام خانوادگی";
            // 
            // txtfield
            // 
            this.txtfield.Location = new System.Drawing.Point(40, 120);
            this.txtfield.Name = "txtfield";
            this.txtfield.Size = new System.Drawing.Size(122, 20);
            this.txtfield.TabIndex = 21;
            this.txtfield.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "کد رشته";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addstu
            // 
            this.addstu.Location = new System.Drawing.Point(172, 290);
            this.addstu.Name = "addstu";
            this.addstu.Size = new System.Drawing.Size(75, 23);
            this.addstu.TabIndex = 29;
            this.addstu.Text = "اضافه";
            this.addstu.UseVisualStyleBackColor = true;
            this.addstu.Click += new System.EventHandler(this.addstu_Click);
            // 
            // cancle
            // 
            this.cancle.Location = new System.Drawing.Point(58, 291);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(75, 23);
            this.cancle.TabIndex = 28;
            this.cancle.Text = "انصراف";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // FRMregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(521, 374);
            this.Controls.Add(this.addstu);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.txtfield);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtfam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtstid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Name = "FRMregister";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ثبت مشخصات دانشجو";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfield;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addstu;
        private System.Windows.Forms.Button cancle;
    }
}